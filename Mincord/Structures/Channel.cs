using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Structures
{
    // https://discord.com/developers/docs/resources/guild#get-guild-channels
    public class OverwriteObjects
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("allow")]
        public string Allow { get; set; }

        [JsonProperty("deny")]
        public string Deny { get; set; }
    }

    public class DefaultReaction
    {
        [JsonProperty("emoji_id")]
        public string EmojiId { get; set; }

        [JsonProperty("emoji_name")]
        public string EmojiName { get; set; }
    }

    public class Tag
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("moderated")]
        public bool Moderated { get; set; }

        [JsonProperty("emoji_id")]
        public string EmojiId { get; set; }

        [JsonProperty("emoji_name")]
        public string EmojiName { get; set; }
    }

    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        [JsonProperty("rate_limit_per_user")]
        public int RateLimitPerUser { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("permission_overwrites")]
        public List<OverwriteObjects> PermissionOverwrites { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("rtc_region")]
        public string RtcRegion { get; set; }

        [JsonProperty("video_quality_mode")]
        public int VideoQualityMode { get; set; }

        [JsonProperty("default_auto_archive_duration")]
        public int DefaultAutoArchiveDuration { get; set; }

        [JsonProperty("default_reaction_emoji")]
        public List<DefaultReaction> DefaultReactionEmoji { get; set; }

        [JsonProperty("available_tags")]
        public List<Tag> AvailableTags { get; set; }

        [JsonProperty("default_sort_order")]
        public int DefaultSortOrder { get; set; }

        [JsonProperty("default_forum_layout")]
        public int DefaultForumLayout { get; set; }

        [JsonProperty("default_thread_rate_limit_per_user")]
        public int DefaultThreadRateLimitPerUser { get; set; }
    }
}
