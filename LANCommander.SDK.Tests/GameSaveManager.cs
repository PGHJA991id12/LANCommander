using LANCommander.SDK.Models;

namespace LANCommander.SDK.Tests
{
    public class GameSaveManager
    {
        Guid SaveId;
        SDK.GameSaveManager Manager;

        public GameSaveManager() {
            var client = new Client("http://localhost:1337");

            Manager = new SDK.GameSaveManager(client);
        }

        [Theory]
        [InlineData("{InstallDir}", "C:\\Games\\Age of Empires", "C:\\Games\\Age of Empires")]
        [InlineData("{InstallDir}\\baseq3", "C:\\Games\\Quake 3\\baseq3", "C:\\Games\\Quake 3")]
        [InlineData("{InstallDir}/baseq3/autoexec.cfg", "C:\\Games\\Quake 3\\baseq3\\autoexec.cfg", "C:\\Games\\Quake 3")]
        [InlineData("%SYSTEMDRIVE%", "C:", "C:\\Games\\Quake 3")]
        [InlineData("%PROGRAMDATA%", "C:\\ProgramData", "C:\\Games\\Quake 3")]
        [InlineData("%SYSTEMROOT%", "C:\\Windows", "C:\\Games\\Quake 3")]
        [InlineData("%USERNAME%", "{UserName}", "C:\\Games")]
        [InlineData("%LOCALAPPDATA%", "C:\\Users\\{UserName}\\AppData\\Local", "C:\\Games")]
        [InlineData("%TEMP%", "C:\\Users\\{UserName}\\AppData\\Local\\Temp", "C:\\Games")]
        public void GetLocalPathBasicsShouldWork(string input, string expected, string installDirectory)
        {
            // Tests to make sure GetLocalPath gets the correct local paths for a given input.
            // Useful to make sure that the full path to the file is returned properly.
            var result = Manager.GetLocalPath(input, installDirectory);

            // To test anything that might have the username in the expected string
            expected = expected.Replace("{UserName}", Environment.UserName);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("C:\\Games\\Age of Empires", "{InstallDir}", "C:\\Games\\Age of Empires")]
        [InlineData("C:\\", "%SystemDrive%\\", "C:\\Games\\")]
        [InlineData("C:\\Games\\Quake 3\\baseq3\\autoexec.cfg", "{InstallDir}\\baseq3\\autoexec.cfg", "C:\\Games\\Quake 3")]
        [InlineData("C:\\Users\\{UserName}\\AppData\\Roaming\\.nfs2e", "%APPDATA%\\.nfs2e", "C:\\Games")]
        [InlineData("C:\\Users\\{UserName}\\AppData\\Local\\.minecraft", "%LOCALAPPDATA%\\.minecraft", "C:\\Games")]

        public void GetArchivePathBasicsShouldWork(string input, string expected, string installDirectory)
        {
            input = input.Replace("{UserName}", Environment.UserName);

            var result = Manager.GetArchivePath(input, installDirectory);

            // To test anything that might have the username in the expected string
            expected = expected.Replace("{UserName}", Environment.UserName);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SimpleInstallDirectorySavePathsShouldWork()
        {
            // Arrange
            var installDirectory = Path.GetTempPath();
            var savePath = new SavePath
            {
                Id = Guid.NewGuid(),
                Path = "base\\autoexec.cfg",
                WorkingDirectory = "{InstallDir}",
                Type = "File",
                IsRegex = false
            };

            // Act
            var entries = Manager.GetFileSavePathEntries(savePath, installDirectory);

            // Assert
            Assert.Single(entries);

            var entry = entries.First();

            Assert.Equal($"base/autoexec.cfg", entry.ArchivePath);
            Assert.Equal("{InstallDir}/base/autoexec.cfg", entry.ActualPath);
        }

        [Fact]
        public void RegexInstallDirectorySavePathsShouldWork()
        {
            // Arrange
            var savePath = new SavePath
            {
                Id = Guid.NewGuid(),
                Path = "base\\.*.cfg",
                WorkingDirectory = "{InstallDir}",
                Type = "File",
                IsRegex = true
            };
            var installDirectory = Path.Combine(Path.GetTempPath(), savePath.Id.ToString());

            Directory.CreateDirectory(installDirectory);
            Directory.CreateDirectory(Path.Combine(installDirectory, "base"));
            File.WriteAllText(Path.Combine(installDirectory, "base", "autoexec.cfg"), savePath.Id.ToString());
            File.WriteAllText(Path.Combine(installDirectory, "base", "player.cfg"), savePath.Id.ToString());

            // Act
            var entries = Manager.GetFileSavePathEntries(savePath, installDirectory);

            // Assert
            Assert.Equal(2, entries.Count());
            Assert.True(File.Exists(Path.Combine($"{Path.GetTempPath()}\\{savePath.Id}\\base\\autoexec.cfg")));
            Assert.True(File.Exists(Path.Combine($"{Path.GetTempPath()}\\{savePath.Id}\\base\\player.cfg")));

            var autoexec = entries.First();
            var player = entries.Last();

            Assert.Equal("base/autoexec.cfg", autoexec.ArchivePath);
            Assert.Equal("{InstallDir}/base/autoexec.cfg", autoexec.ActualPath);

            Assert.Equal("base/player.cfg", player.ArchivePath);
            Assert.Equal("{InstallDir}/base/player.cfg", player.ActualPath);
        }
    }
}