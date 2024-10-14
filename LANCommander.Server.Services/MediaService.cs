﻿using Force.Crc32;
using LANCommander.Server.Data;
using LANCommander.Server.Data.Models;
using LANCommander.Helpers;
using Syncfusion.PdfToImageConverter;
using System.Net.Mime;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace LANCommander.Server.Services
{
    public class MediaService : BaseDatabaseService<Media>
    {
        private readonly StorageLocationService StorageLocationService;

        public MediaService(
            ILogger<MediaService> logger,
            Repository<Media> repository,
            StorageLocationService storageLocationService) : base(logger, repository)
        {
            StorageLocationService = storageLocationService;
        }

        public override Task Delete(Media entity)
        {
            FileHelpers.DeleteIfExists(GetImagePath(entity));

            return base.Delete(entity);
        }

        public bool FileExists(Media entity)
        {
            var path = GetImagePath(entity);

            return File.Exists(path);
        }

        public async Task<bool> FileExists(Guid id)
        {
            var path = await GetImagePath(id);

            return File.Exists(path);
        }

        public async Task<string> GetImagePath(Guid id)
        {
            var entity = await Get(id);

            return GetImagePath(entity);
        }

        public static string GetImagePath(Media entity)
        {
            return Path.Combine(entity.StorageLocation.Path, entity.FileId.ToString());
        }

        /*public async Task<Media> UploadMediaAsync(Stream stream, Media media)
        {
            return await UploadMediaAsync(stream, media);
            // return await UploadMediaAsync(file.OpenReadStream(maxAllowedSize: Settings.Media.MaxSize * 1024 * 1024), media);
        }*/

        public async Task<Media> UploadMediaAsync(Stream stream, Media media)
        {
            var fileId = Guid.NewGuid();
            var storageLocation = await StorageLocationService.FirstOrDefault(l => l.Default);

            media.FileId = fileId;
            media.StorageLocation = storageLocation;

            var path = GetImagePath(media);

            using (var fs = new FileStream(path, FileMode.Create))
            {
                await stream.CopyToAsync(fs);

                if (media.MimeType == MediaTypeNames.Application.Pdf)
                {
                    using (var ms = new MemoryStream())
                    {
                        await stream.CopyToAsync(ms);

                        var thumbnail = await GeneratePdfThumbnailAsync(ms);

                        media.Thumbnail = thumbnail;
                    }
                }
            }

            media.Crc32 = SDK.Services.MediaService.CalculateChecksum(path);

            return media;
        }

        private async Task<Media> GeneratePdfThumbnailAsync(Stream inputStream)
        {
            var fileId = Guid.NewGuid();
            var storageLocation = await StorageLocationService.FirstOrDefault(l => l.Default);

            var media = new Media
            {
                FileId = fileId,
                MimeType = MediaTypeNames.Application.Pdf,
                Type = SDK.Enums.MediaType.Thumbnail,
                StorageLocation = storageLocation
            };

            var path = GetImagePath(media);

            PdfToImageConverter converter = new PdfToImageConverter();

            converter.Load(inputStream);

            var outputStream = converter.Convert(0, false, true);

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                try
                {
                    outputStream.Position = 0;
                    await outputStream.CopyToAsync(fs);
                }
                catch (Exception ex)
                {
                    Logger?.LogError(ex, "Could not write thumbnail for PDF");

                    if (File.Exists(path))
                        File.Delete(path);
                }
            }

            media.Crc32 = SDK.Services.MediaService.CalculateChecksum(path);

            return media;
        }

        public void DeleteLocalMediaFile(Media media)
        {
            var path = GetImagePath(media);

            if (File.Exists(path))
                File.Delete(path);
        }

        public async Task<Media> DownloadMediaAsync(string sourceUrl, Media media)
        {
            var fileId = Guid.NewGuid();
            var storageLocation = await StorageLocationService.FirstOrDefault(l => l.Default);

            media.FileId = fileId;
            media.StorageLocation = storageLocation;

            var path = GetImagePath(media);

            using (var http = new HttpClient())
            using (var fs = new FileStream(path, FileMode.Create))
            {
                using (var ms = new MemoryStream())
                {
                    var response = await http.GetStreamAsync(sourceUrl);

                    await response.CopyToAsync(ms);

                    if (media.MimeType == MediaTypeNames.Application.Pdf)
                    {
                        var thumbnail = await GeneratePdfThumbnailAsync(ms);

                        media.Thumbnail = thumbnail;
                    }

                    ms.Position = 0;

                    await ms.CopyToAsync(fs);
                }
            }

            media.Crc32 = SDK.Services.MediaService.CalculateChecksum(path);

            return media;
        }
    }
}
