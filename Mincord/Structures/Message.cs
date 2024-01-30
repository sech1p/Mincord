using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Structures
{
    public class Author
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        [JsonProperty("public_flags")]
        public int PublicFlags { get; set; }

        [JsonProperty("premium_type")]
        public int PremiumType { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("accent_color")]
        public int? AccentColor { get; set; }

        [JsonProperty("global_name")]
        public string GlobalName { get; set; }

        [JsonProperty("avatar_decoration_data")]
        public string AvatarDecorationData { get; set; }

        [JsonProperty("banner_color")]
        public int? BannerColor { get; set; }
    }

    public class MentionRoles
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("Hoist")]
        public bool Hoist { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("managed")]
        public bool Managed { get; set; }

        [JsonProperty("mentionable")]
        public bool Mentionable { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("proxy_url")]
        public string ProxyUrl { get; set; }
    }

    public class Embed
    {
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Messages
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("edited_timestamp")]
        public string EditedTimestamp { get; set; }

        [JsonProperty("tts")]
        public bool Tts { get; set; }

        [JsonProperty("mention_everyone")]
        public bool MentionEveryone { get; set; }

        [JsonProperty("mention_roles")]
        public List<MentionRoles> MentionRoles { get; set; }

        [JsonProperty("attachment")]
        public List<Attachment> Attachment { get; set; }

        [JsonProperty("embed")]
        public List<Embed> Embed { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }
}
