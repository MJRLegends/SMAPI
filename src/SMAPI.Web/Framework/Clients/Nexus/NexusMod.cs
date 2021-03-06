using Newtonsoft.Json;
using StardewModdingAPI.Toolkit;

namespace StardewModdingAPI.Web.Framework.Clients.Nexus
{
    /// <summary>Mod metadata from Nexus Mods.</summary>
    internal class NexusMod
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The mod name.</summary>
        public string Name { get; set; }

        /// <summary>The mod's semantic version number.</summary>
        public string Version { get; set; }

        /// <summary>The latest file version.</summary>
        public ISemanticVersion LatestFileVersion { get; set; }

        /// <summary>The mod's web URL.</summary>
        [JsonProperty("mod_page_uri")]
        public string Url { get; set; }

        /// <summary>A user-friendly error which indicates why fetching the mod info failed (if applicable).</summary>
        [JsonIgnore]
        public string Error { get; set; }
    }
}
