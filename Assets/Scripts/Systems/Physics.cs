using Entitas;
namespace Systems
{
    public class Physics : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly Components.Physics _physics;

        public Physics(Contexts contexts)
        {
            _contexts = contexts;
            _physics = contexts.physics.componentsPhysics;
        }
        
        public void Execute()
        {
            foreach (var collisionInfo in _physics.CollisionInfos) {
                var sourceEntity = _contexts.game.GetEntityWithComponentsId(collisionInfo.sourceId);
                var otherEntity = _contexts.game.GetEntityWithComponentsId(collisionInfo.otherId);

                if (sourceEntity.isComponentsTagsBullet) {
                    if (otherEntity.isComponentsTagsEnemy) {
                        sourceEntity.isComponentsFlagsDestroy = true;
                        otherEntity.isComponentsFlagsDestroy = true;
                    }
                }
            }
            
            _physics.CollisionInfos.Clear();
        }
    }
}