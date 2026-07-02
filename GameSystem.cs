namespace ImmortalIdle.Core
{
    public abstract class GameSystem
    {
        public virtual void Initialize() {}

        public virtual void Update() {}

        public virtual void Save() {}

        public virtual void Load() {}
    }
}
