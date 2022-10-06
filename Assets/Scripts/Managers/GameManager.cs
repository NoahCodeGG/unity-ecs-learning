using System;
using System.Collections.Generic;
using Other;
using UnityEngine;
namespace Managers
{
    /// <summary>
    ///     游戏 manager
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        public static Contexts Contexts => Instance._contexts;

        private Contexts _contexts;
        private GameSystems _gameSystems;
        private FixedUpdateGameSystems _fixedUpdateGameSystems;

        private void Awake()
        {
            if (Instance != null) Destroy(Instance.gameObject);

            Instance = this;

            _contexts = Contexts.sharedInstance;
            _contexts.SubscribeId();
            _contexts.physics.CreateEntity().AddComponentsPhysics(new List<CollisionInfo>());
            _gameSystems = new GameSystems(_contexts);
            _fixedUpdateGameSystems = new FixedUpdateGameSystems(_contexts);
        }

        private void Start()
        {
            // 初始化
            _gameSystems.Initialize();
        }

        private void FixedUpdate()
        {
            _fixedUpdateGameSystems.Execute();
            _fixedUpdateGameSystems.Cleanup();
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