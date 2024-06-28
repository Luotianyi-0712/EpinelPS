﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nksrv.StaticInfo
{
    public static class StageCompletionReward
    {
        // <Stage ID, Reward data>
        public static readonly Dictionary<int, NetRewardData> RewardData =
        new() {
            { 6000001, new NetRewardData() { Currency = { 
                    new NetCurrencyData() { Type = (int)CurrencyType.Gold, Value = 500 },
                     new NetCurrencyData() { Type = (int)CurrencyType.CharacterExp , Value = 600 }
                } }
            },
            { 6000002, new NetRewardData() { Currency = {
                    new NetCurrencyData() { Type = (int)CurrencyType.Gold, Value = 500 },
                     new NetCurrencyData() { Type = (int)CurrencyType.CharacterExp , Value = 600 }
                } }
            },
            { 6000003, new NetRewardData() { Currency = {
                    new NetCurrencyData() { Type = (int)CurrencyType.Gold, Value = 500 },
                     new NetCurrencyData() { Type = (int)CurrencyType.CharacterExp , Value = 600 }
                } }
            },
        };
    }
}