using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Structures
{
    public class Guild
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("home_header")]
        public string HomeHeader { get; set; }

        [JsonProperty("splash")]
        public string Splash { get; set; }

        [JsonProperty("discovery_splash")]
        public string DiscoverySplash { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("afk_channel_id")]
        public string AfkChannelId { get; set; }

        [JsonProperty("afk_timeout")]
        public int AfkTimeout { get; set; }

        [JsonProperty("system_channel_id")]
        public string SystemChannelId { get; set; }

        [JsonProperty("system_channel_flags")]
        public string SystemChannelFlags { get; set; }

        [JsonProperty("widget_enabled")]
        public bool WidgetEnabled { get; set; }

        [JsonProperty("widget_channel_id")]
        public string WidgetChannelId { get; set; }

        [JsonProperty("verification_level")]
        public int VerificationLevel { get; set; }

        [JsonProperty("roles")]
        public List<string> roles { get; set; }

        [JsonProperty("default_message_notifications")]
        public int DefaultMessageNotifications { get; set; }

        [JsonProperty("mfa_level")]
        public int MfaLevel { get; set; }

        [JsonProperty("explicit_content_filter")]
        public int ExplicitContentFilter { get; set; }

        [JsonProperty("max_presecences")]
        public int MaxPresences { get; set; }

        [JsonProperty("max_members")]
        public int MaxMembers { get; set; }

        [JsonProperty("max_stage_video_channel_users")]
        public int MaxStageVideoChannelUsers { get; set; }

        [JsonProperty("max_video_channel_users")]
        public int MaxVideoChannelUsers { get; set; }

        [JsonProperty("vanity_url_code")]
        public int VanityUrlCode { get; set; }

        [JsonProperty("premium_tier")]
        public int PremiumTier { get; set; }

        [JsonProperty("premium_subscription_count")]
        public int PremiumSubscriptionCount { get; set; }

        [JsonProperty("preferred_locale")]
        public string PrefferedLocale { get; set; }

        [JsonProperty("rules_channel_id")]
        public string RulesChannelId { get; set; }

        [JsonProperty("safety_alerts_channel_id")]
        public string SafetyAlertsChannelId { get; set; }

        [JsonProperty("public_updates_channel_id")]
        public int PublicUpdatesChannelId { get; set; }

        [JsonProperty("hub_type")]
        public int HubType { get; set; }

        [JsonProperty("premium_progress_bar_enabled")]
        public bool PremiumProgressBarEnabled { get; set; }

        [JsonProperty("latest_onboarding_question_id")]
        public int LatestOnboardingQuestionId { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("nsfw_level")]
        public int NsfwLevel { get; set; }

        [JsonProperty("emojis")]
        public List<string> Emojis { get; set; }

        [JsonProperty("stickers")]
        public List<string> Stickers { get; set; }

        [JsonProperty("incidents_data")]
        public int IncidentsData { get; set; }
        
        [JsonProperty("inventory_settings")]
        public int InventorySettings { get; set; }

        [JsonProperty("embed_enabled")]
        public bool EmbedEnabled { get; set; }

        [JsonProperty("embed_channel_id")]
        public string EmbedChannelId { get; set; }
    }
}
