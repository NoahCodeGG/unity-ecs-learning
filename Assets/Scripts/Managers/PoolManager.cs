using System.Collections.Generic;
using Hybrid;
using Other;
using UnityEngine;
namespace Managers
{
    /// <summary>
    ///     对象池 manager （单例）
    /// </summary>
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        [SerializeField]public ActorTagPathDictionary actorTagPathDictionary;

        private readonly Dictionary<ActorTag, ViewPrefabPool> _viewPrefabPools = new();

        private void Awake()
        {
            if (Instance != null) Destroy(Instance.gameObject);

            Instance = this;
        }

        public View Spawn(ActorTag actorTag)
        {
            if (_viewPrefabPools.TryGetValue(actorTag, out var pool)) return pool.Spawn();

            pool = new ViewPrefabPool {
                Prefab = Resources.Load<GameObject>(actorTagPathDictionary[actorTag]),
                SpawnRoot = new GameObject($"_SpawnRoot_{actorTag.ToString()}").transform,
                PoolRoot = new GameObject($"_PoolRoot_{actorTag.ToString()}").transform
            };

            pool.SpawnRoot.SetParent(transform);
            pool.SpawnRoot.localPosition = Vector3.zero;
            pool.SpawnRoot.localRotation = Quaternion.identity;
            pool.SpawnRoot.localScale = Vector3.one;

            pool.PoolRoot.SetParent(transform);
            pool.PoolRoot.localPosition = Vector3.zero;
            pool.PoolRoot.localRotation = Quaternion.identity;
            pool.PoolRoot.localScale = Vector3.one;

            _viewPrefabPools.Add(actorTag, pool);

            return pool.Spawn();
        }

        public T Spawn<T>(ActorTag actorTag) where T:class, IView
        {
            return Spawn(actorTag) as T;
        }

        public bool Recycle(View view, ActorTag actorTag)
        {
            if (_viewPrefabPools.TryGetValue(actorTag, out var pool)) return pool.Recycle(view);

            Destroy(view.gameObject);
            return false;
        }
    }
}