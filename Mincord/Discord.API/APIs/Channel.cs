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

        public async Task<string> GetDMs()
        {
            var token = Properties.Settings.Default["Token"];
            var dm = await Endpoints.USER_ME_CHANNELS_ENDPOINT
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return dm;
        }

        public async Task<string> GetDM(string dmID)
        {
            var token = Properties.Settings.Default["Token"];
            var dm = await $"{Endpoints.CHANNEL_ENDPOINT}/{dmID}/messages"
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return dm;
        }
    }
}
