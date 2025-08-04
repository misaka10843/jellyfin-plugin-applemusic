using System;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.AppleMusic.Configuration
{
    /// <summary>
    /// The (empty) plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {


        /// <summary>
        /// Gets or sets the apple music Region.
        /// </summary>
        public string AppleMusicRegion { get; set; } = "us";
    }
}
