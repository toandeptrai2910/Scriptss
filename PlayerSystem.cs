using ImmortalIdle.Core;

namespace ImmortalIdle.Player
{
    public class PlayerSystem : GameSystem
    {
        public PlayerModel Player { get; private set; }

        public override void Initialize()
        {
            Player = new PlayerModel();
        }
    }
}
