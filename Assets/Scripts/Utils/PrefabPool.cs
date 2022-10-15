using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
namespace Utils
{
    public class PrefabPool
    {
        protected readonly Stack<GameObject> _inPoolObjects = new();
        protected readonly HashSet<GameObject> _outPoolObjects = new();
        public Transform PoolRoot;
        public GameObject Prefab;
        public Transform SpawnRoot;

        /// <summary>
        ///     初始化
        /// </summary>
        /// <param name="count"></param>
        public void Preload(int count)
        {
            if (Prefab == null) return;

            if (_inPoolObjects.Count + _outPoolObjects.Count >= count) return;

            var n = count - _inPoolObjects.Count - _outPoolObjects.Count;
            for (var i = 0; i < n; i++) {
                var obj = Object.Instantiate(Prefab, Vector3.zero, Quaternion.identity);
                obj.SetActive(false);
                obj.transform.SetParent(PoolRoot);
                _inPoolObjects.Push(obj);
            }

        }

        /// <summary>
        ///     生成对象
        /// </summary>
        /// <returns></returns>
        public GameObject Spawn()
        {
            GameObject obj;

            if (_inPoolObjects.Count > 0) {
                obj = _inPoolObjects.Pop();
                _outPoolObjects.Add(obj);
                return obj;
            }

            obj = Object.Instantiate(Prefab, Vector3.zero, Quaternion.identity);
            _outPoolObjects.Add(obj);
            obj.SetActive(true);
            obj.transform.SetParent(SpawnRoot);
            return obj;
        }

        /// <summary>
        ///     回收对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Recycle(GameObject obj)
        {
            if (!_outPoolObjects.Contains(obj)) {
                Object.Destroy(obj);
                return false;
            }

            _outPoolObjects.Remove(obj);
            obj.SetActive(false);
            obj.transform.SetParent(PoolRoot);
            _inPoolObjects.Push(obj);
            return true;
        }
    }
}

[Serializable]
public class PrefabPool<T> where T:Component
{
    public Transform PoolRoot;
    public GameObject Prefab;
    public Transform SpawnRoot;

    protected readonly Stack<T> _inPoolObjects = new();
    protected readonly HashSet<T> _outPoolObjects = new();

    /// <summary>
    ///     初始化
    /// </summary>
    /// <param name="count"></param>
    public void Preload(int count)
    {
        if (Prefab == null) return;

        if (_inPoolObjects.Count + _outPoolObjects.Count >= count) return;

        var n = count - _inPoolObjects.Count - _outPoolObjects.Count;
        for (var i = 0; i < n; i++) {
            var obj = Object.Instantiate(Prefab, Vector3.zero, Quaternion.identity);
            obj.SetActive(false);
            _inPoolObjects.Push(obj.GetComponent<T>());
        }

    }

    /// <summary>
    ///     生成对象
    /// </summary>
    /// <returns></returns>
    public T Spawn()
    {
        T obj;

        if (_inPoolObjects.Count > 0) {
            obj = _inPoolObjects.Pop();
            _outPoolObjects.Add(obj);
            return obj;
        }

        obj = Object.Instantiate(Prefab, Vector3.zero, Quaternion.identity).GetComponent<T>();
        _outPoolObjects.Add(obj);
        obj.gameObject.SetActive(true);
        obj.transform.SetParent(SpawnRoot);
        return obj;
    }

    /// <summary>
    ///     回收对象
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public bool Recycle(T obj)
    {
        if (!_outPoolObjects.Contains(obj)) {
            Object.Destroy(obj);
            return false;
        }

        _outPoolObjects.Remove(obj);
        obj.gameObject.SetActive(false);
        obj.transform.SetParent(PoolRoot);
        _inPoolObjects.Push(obj);
        return true;
    }
}