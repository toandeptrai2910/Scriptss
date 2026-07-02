using System;

namespace ImmortalIdle.Player
{
    [Serializable]
    public class PlayerStats
    {
        public double MaxHP = 100;

        public double HP = 100;

        public double Attack = 10;

        public double Defense = 5;

        public double AttackSpeed = 1.0;

        public double CritChance = 0.05;

        public double CritDamage = 1.5;

        public double Dodge = 0.02;

        public double Accuracy = 1.0;
    }
}
