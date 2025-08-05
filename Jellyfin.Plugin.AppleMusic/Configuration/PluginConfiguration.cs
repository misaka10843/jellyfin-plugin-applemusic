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
        /// Gets or sets the Apple Music Region.
        /// </summary>
        public string AppleMusicRegion { get; set; } = "us";

        /// <summary>
        /// Gets or sets the Apple Music album title(like: Albums or アルバム or 专辑).
        /// </summary>
        public string AppleMusicAlbumTitle { get; set; } = "Albums";

        /// <summary>
        /// Gets or sets the Apple Music album title(like: Artists or アーティスト or 艺人).
        /// </summary>
        public string AppleMusicArtistTitle { get; set; } = "Artists";
    }
}
