using System.Collections.Generic;

namespace ImmortalIdle.Core
{
    public class SystemManager
    {
        private readonly List<GameSystem> systems = new();

        public void Register(GameSystem system)
        {
            systems.Add(system);
        }

        public void Initialize()
        {
            foreach (var system in systems)
                system.Initialize();
        }

        public void Update()
        {
            foreach (var system in systems)
                system.Update();
        }

        public void Save()
        {
            foreach (var system in systems)
                system.Save();
        }

        public void Load()
        {
            foreach (var system in systems)
                system.Load();
        }
    }
}
