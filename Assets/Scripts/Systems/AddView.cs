using System.Collections.Generic;
using Entitas;
using Hybrid;
using Managers;
using UnityEngine;
namespace Systems
{
    /// <summary>
    /// 添加可视 system
    /// </summary>
    public class AddView : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public AddView(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            // 当添加 CreateGameObjectCmd 时触发
            return context.CreateCollector(GameMatcher.ComponentsCmdCreateGameObject);
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            // 添加 view 与 移除 CreateGameObjectCmd
            foreach (var entity in entities) {
                var view = SpawnObject(entity);
                entity.AddComponentsView(view);
                entity.RemoveComponentsCmdCreateGameObject();
            }
        }

        private View SpawnObject(GameEntity entity)
        {
            var path = entity.componentsCmdCreateGameObject.Path;
            View view;
            
            if (path == "Bullet") { // 若 GameObject 为子弹时，从子弹对象池生成
                view = PoolManager.Instance.bulletPrefabPool.Spawn();
            } else { // 根据路径直接获取 GameObject 的 view
                var prefab = Resources.Load<GameObject>(path);
                var obj = Object.Instantiate(prefab, Vector3.zero, Quaternion.identity);
                view = obj.GetComponent<View>();
            }
            // 关联 view
            view.Link(_contexts, entity);
            return view;
        }
    }
}