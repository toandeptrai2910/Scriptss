using UnityEngine;

namespace ImmortalIdle.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            Debug.Log("Game Started");
        }

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            Debug.Log("Initialize Systems");
        }
    }
}
