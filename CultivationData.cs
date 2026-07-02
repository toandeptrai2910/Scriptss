using System;

namespace ImmortalIdle.Cultivation
{
    [Serializable]
    public class CultivationData
    {
        public RealmType Realm = RealmType.Mortal;

        public int MinorStage = 1;

        public double CultivationExp = 0;

        public double RequiredExp = 100;
    }
}
