using System;
using ImmortalIdle.Cultivation;

namespace ImmortalIdle.Player
{
    [Serializable]
    public class PlayerModel
    {
        public PlayerData Data = new();

        public PlayerStats Stats = new();

        public CultivationData Cultivation = new();
    }
}
