using System.Collections.Generic;
using Entitas;
using Hybrid;
using Managers;
using UnityEngine;
namespace Systems
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.ComponentsCreateGameObjectCmd);
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities) {
                var view = SpawnObject(entity);
                entity.AddComponentsView(view);
                entity.RemoveComponentsCreateGameObjectCmd();
            }
        }

        private View SpawnObject(GameEntity entity)
        {
            var path = entity.componentsCreateGameObjectCmd.Path;
            var prefab = Resources.Load<GameObject>(path);
            View view = null;
            if (path == "Bullet") {
                view = PoolManager.Instance.bulletPrefabPool.Spawn();
            } else {
                var obj = Object.Instantiate(prefab, Vector3.zero, Quaternion.identity);
                view = obj.GetComponent<View>();
            }
            view.Link(_contexts, entity);
            return view;
        }
    }
}