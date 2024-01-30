using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Discord.API.APIs
{
    class Channel
    {
        public async Task<string> GetChannels(string guildID)
        {
            var token = Properties.Settings.Default["Token"];
            var guild = await $"{Endpoints.GUILDS_ENDPOINT}/{guildID}/channels"
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return guild;
        }
    }
}
