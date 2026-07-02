using System;

namespace ImmortalIdle.Player
{
    [Serializable]
    public class PlayerData
    {
        public string PlayerName = "Immortal";

        public long Level = 1;

        public long Experience = 0;

        public long ExperienceToNext = 100;

        public long Gold = 0;

        public long SpiritStone = 0;

        public long PremiumCurrency = 0;
    }
}
