using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Structures
{
    public class User
    {
        public class UserData
        {
            public string id { get; set; }
            public string username { get; set; }
            public string avatar { get; set; }
            public string discriminator { get; set; }
            public string public_flags { get; set; }
            public string premium_type { get; set; }
            public int flags { get; set; }
            public string banner { get; set; }
            public int accent_color { get; set; }
            public bool mfa_enabled { get; set; }
            public string locale { get; set; }
            public string email { get; set; }
            public bool verified { get; set; }
            public string phone { get; set; }
            public bool nsfw_allowed { get; set; }
            public string[] linked_users { get; set; }
            public int purchased_flags { get; set; }
            public string bio { get; set; }
            public int[] authenticator_types { get; set; }
            public string global_name { get; set; }
        }

        public class Guild
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("owner")]
            public bool Owner { get; set; }

            [JsonProperty("permissions")]
            public int Permissions { get; set; }

            [JsonProperty("permissions_new")]
            public string PermissionsNew { get; set; }

            [JsonProperty("features")]
            public List<string> Features { get; set; }
        }

        public class GuildList
        {
            public List<Guild> Guilds { get; set; }
        }
    }
}
