using EpinelPS.Net;
using EpinelPS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpinelPS.LobbyServer.Msgs.Intercept
{
    [PacketPath("/intercept/check")]
    public class CheckClearInterceptToday : LobbyMsgHandler
    {
        protected override async Task HandleAsync()
        {
            var req = await ReadData<ReqCheckClearInterceptToday>();

            var response = new ResCheckClearInterceptToday
            {
                Clear = true
            };

            await WriteDataAsync(response);
        }
    }
}