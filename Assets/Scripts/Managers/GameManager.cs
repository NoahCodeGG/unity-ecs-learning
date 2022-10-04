using UnityEngine;
namespace Managers
{
    /// <summary>
    ///     游戏 manager
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private GameSystems _gameSystems;

        private void Awake()
        {
            _gameSystems = new GameSystems(Contexts.sharedInstance);
        }

        private void Start()
        {
            // 初始化
            _gameSystems.Initialize();
        }

        private void Update()
        {
            // 执行与清理
            _gameSystems.Execute();
            _gameSystems.Cleanup();
        }

        private void OnDestroy()
        {
            // 释放
            _gameSystems.TearDown();
        }
    }
}