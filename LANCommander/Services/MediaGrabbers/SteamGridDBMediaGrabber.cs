﻿using craftersmine.SteamGridDBNet;
using LANCommander.Data.Enums;
using LANCommander.Models;
using LANCommander.SDK.Enums;
using LANCommander.Steam;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Mime;

namespace LANCommander.Services.MediaGrabbers
{
    public class SteamGridDBMediaGrabber : IMediaGrabberService
    {
        SteamGridDb SteamGridDb { get; set; }
        SteamClient SteamClient { get; set; }

        private SteamGridDbFormats[] SupportedFormats = new SteamGridDbFormats[]
        {
            SteamGridDbFormats.Ico,
            SteamGridDbFormats.Png,
            SteamGridDbFormats.Jpeg,
            SteamGridDbFormats.Webp
        };

        public SteamGridDBMediaGrabber()
        {
            var settings = SettingService.GetSettings();

            SteamGridDb = new SteamGridDb(settings.Media.SteamGridDbApiKey);
            SteamClient = new SteamClient();
        }

        public async Task<IEnumerable<MediaGrabberResult>> SearchAsync(MediaType type, string keywords)
        {
            var games = await SteamGridDb.SearchForGamesAsync(keywords);

            var results = new List<MediaGrabberResult>();

            if (type == MediaType.Manual)
                return await GetManualsAsync(keywords);

            foreach (var game in games)
            {
                switch (type)
                {
                    case MediaType.Icon:
                        results.AddRange(await GetIconsAsync(game));
                        break;

                    case MediaType.Cover:
                        results.AddRange(await GetCoversAsync(game));
                        break;

                    case MediaType.Background:
                        results.AddRange(await GetBackgroundsAsync(game));
                        break;

                    case MediaType.Logo:
                        results.AddRange(await GetLogosAsync(game));
                        break;
                }
            }

            return results;
        }

        private async Task<IEnumerable<MediaGrabberResult>> GetIconsAsync(SteamGridDbGame game)
        {
            var icons = await SteamGridDb.GetIconsByGameIdAsync(game.Id);

            return icons.Where(i => SupportedFormats.Contains(i.Format)).Select(i => new MediaGrabberResult()
            {
                Id = i.Id.ToString(),
                Type = MediaType.Icon,
                SourceUrl = i.Format == SteamGridDbFormats.Ico ? i.ThumbnailImageUrl : i.FullImageUrl,
                ThumbnailUrl = i.ThumbnailImageUrl,
                Group = game.Name,
                MimeType = GetMimeType(i.Format)
            });
        }

        private async Task<IEnumerable<MediaGrabberResult>> GetCoversAsync(SteamGridDbGame game)
        {
            var covers = await SteamGridDb.GetGridsByGameIdAsync(game.Id);

            return covers.Where(c => SupportedFormats.Contains(c.Format)).Select(c => new MediaGrabberResult()
            {
                Id = c.Id.ToString(),
                Type = MediaType.Cover,
                SourceUrl = c.FullImageUrl,
                ThumbnailUrl = c.ThumbnailImageUrl,
                Group = game.Name,
                MimeType = GetMimeType(c.Format)
            });
        }

        private async Task<IEnumerable<MediaGrabberResult>> GetBackgroundsAsync(SteamGridDbGame game)
        {
            var backgrounds = await SteamGridDb.GetHeroesByGameIdAsync(game.Id);

            return backgrounds.Where(b => SupportedFormats.Contains(b.Format)).Select(b => new MediaGrabberResult()
            {
                Id = b.Id.ToString(),
                Type = MediaType.Background,
                SourceUrl = b.FullImageUrl,
                ThumbnailUrl = b.ThumbnailImageUrl,
                Group = game.Name,
                MimeType = GetMimeType(b.Format)
            });
        }

        private async Task<IEnumerable<MediaGrabberResult>> GetLogosAsync(SteamGridDbGame game)
        {
            var logos = await SteamGridDb.GetLogosByGameIdAsync(game.Id);

            return logos.Where(b => SupportedFormats.Contains(b.Format)).Select(b => new MediaGrabberResult()
            {
                Id = b.Id.ToString(),
                Type = MediaType.Logo,
                SourceUrl = b.FullImageUrl,
                ThumbnailUrl = b.ThumbnailImageUrl,
                Group = game.Name,
                MimeType = GetMimeType(b.Format)
            });
        }

        private async Task<IEnumerable<MediaGrabberResult>> GetManualsAsync(string keywords)
        {
            var appIdResults = await SteamClient.SearchGamesAsync(keywords);

            var results = new List<MediaGrabberResult>();

            foreach (var appIdResult in appIdResults)
            {
                var hasManual = await SteamClient.HasManualAsync(appIdResult.AppId);

                if (!hasManual)
                    continue;

                var result = new MediaGrabberResult()
                {
                    Id = appIdResult.AppId.ToString(),
                    Type = MediaType.Manual,
                    SourceUrl = SteamClient.GetManualUri(appIdResult.AppId).ToString(),
                    Group = appIdResult.Name,
                    MimeType = MediaTypeNames.Application.Pdf,
                    ThumbnailUrl = "/static/pdf.png"
                };

                results.Add(result);
            }

            return results;
        }

        private string GetMimeType(SteamGridDbFormats format)
        {
            switch (format)
            {
                case SteamGridDbFormats.Png:
                case SteamGridDbFormats.Ico:
                    return MediaTypeNames.Image.Png;
                case SteamGridDbFormats.Jpeg:
                    return MediaTypeNames.Image.Jpeg;
                case SteamGridDbFormats.Webp:
                    return MediaTypeNames.Image.Webp;
                default:
                    throw new NotImplementedException("The SteamGridDB grabber currently does not support this format");
            }
        }
    }
}
