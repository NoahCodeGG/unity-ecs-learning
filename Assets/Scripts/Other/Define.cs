using System;
using Hybrid;
namespace Other
{
    [Serializable]
    public enum ActorTag
    {
        Player,
        Bullet,
        Enemy
    }

    [Serializable]
    public class ActorTagPathDictionary : SerializableDictionary<ActorTag, string>
    {
    }

    /// <summary>
    ///     可视预制体池
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