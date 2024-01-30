using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Discord.API.APIs
{
    class Guild
    {
        public async Task<string> GetGuilds()
        {
            var token = Properties.Settings.Default["Token"];
            var guilds = await Endpoints.USER_ME_GUILDS_ENDPOINT
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return guilds;
        }

        public async Task<string> GetGuild(string guildID)
        {
            var token = Properties.Settings.Default["Token"];
            var guild = await $"{Endpoints.GUILDS_ENDPOINT}/{guildID}"
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return guild;
        }
    }
}
