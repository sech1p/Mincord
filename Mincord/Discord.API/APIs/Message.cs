using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Discord.API.APIs
{
    public class Message
    {
        private string channelId;

        public Message(string channelId)
        {
            this.channelId = channelId;
        }

        public async Task SendMessage(string channelId, string content)
        {
            var token = Properties.Settings.Default["Token"];
            await $"{Endpoints.CHANNEL_ENDPOINT}/{channelId}/messages"
                .WithHeader("Authorization", token)
                .WithHeader("Content-Type", "application/json")
                .PostJsonAsync(new { content });
        }

        public async Task<string> Messages(string channelId)
        {
            var token = Properties.Settings.Default["Token"];
            var user = await $"{Endpoints.CHANNEL_ENDPOINT}/{channelId}/messages"
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return user;
        }
    }
}
