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

        public ViewPrefabPool bulletPrefabPool;

        private void Awake()
        {
            if (Instance != null) Destroy(Instance.gameObject);

            Instance = this;
        }
    }
}