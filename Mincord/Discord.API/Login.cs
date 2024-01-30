using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Flurl;
using Flurl.Http;

namespace Mincord.Discord.API
{
    class Login
    {
        public async Task LoginAsync(string token)
        {
            await Endpoints.USER_ME_ENDPOINT
                .WithHeader("Authorization", token)
                .WithHeader("Content-Type", "application/json")
                .GetStringAsync();
        }
    }
}
