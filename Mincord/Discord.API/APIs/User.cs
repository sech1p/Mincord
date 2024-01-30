using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mincord.Discord.API.APIs
{
    class User
    {
        public async Task<string> UserMe()
        {
            var token = Properties.Settings.Default["Token"];
            var user = await Endpoints.USER_ME_ENDPOINT
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return user;
        }

        public async Task<string> UserSomeone()
        {
            var token = Properties.Settings.Default["Token"];
            var user = await Endpoints.USER_ME_ENDPOINT
                .WithHeader("Authorization", token)
                .GetStringAsync();
            return user;
        }
    }
}
