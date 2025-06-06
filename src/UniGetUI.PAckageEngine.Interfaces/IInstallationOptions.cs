using System.Runtime.InteropServices;
using UniGetUI.PackageEngine.Enums;
using UniGetUI.PackageEngine.Serializable;

namespace UniGetUI.PackageEngine.Interfaces
{
    public interface IInstallationOptions
    {
        public bool SkipHashCheck { get; set; }
        public bool InteractiveInstallation { get; set; }
        public bool RunAsAdministrator { get; set; }
        public string Version { get; set; }
        public bool SkipMinorUpdates { get; set; }
        public Architecture? Architecture { get; set; }
        public PackageScope? InstallationScope { get; set; }
        public List<string> CustomParameters { get; set; }
        public bool RemoveDataOnUninstall { get; set; }
        public bool PreRelease { get; set; }
        public string CustomInstallLocation { get; set; }
        public bool OverridesNextLevelOpts { get; set; }

        /// <summary>
        /// Loads and applies the options from the given SerializableInstallationOptions object to the current object.
        /// </summary>
        public void GetValuesFromSerializable(SerializableInstallationOptions options);

        /// <summary>
        /// Returns a SerializableInstallationOptions object containing the options of the current instance.
        /// </summary>
        public SerializableInstallationOptions ToSerializable();

        /// <summary>
        /// Saves the current options to disk.
        /// </summary>
        public void SaveToDisk();

        /// <summary>
        /// Returns a string representation of the current options.
        /// </summary>
        public string ToString();
    }
}
