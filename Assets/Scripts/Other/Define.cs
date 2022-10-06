using System;
using Hybrid;
namespace Other
{
    /// <summary>
    /// 可视预制体池
    /// </summary>
    [Serializable]
    public class ViewPrefabPool : PrefabPool<View>
    {
    }

    [Serializable]
    public struct CollisionInfo
    {
        public int sourceId;
        public int otherId;
    }
}