using System.Collections.Generic;
using Entitas;
using Hybrid;
using Managers;
using Other;
namespace Systems
{
    public class Fire : ReactiveSystem<GameEntity>
    {

        private readonly Contexts _contexts;

        public Fire(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AllOf(
                GameMatcher.ComponentsTagsPlayer,
                GameMatcher.ComponentsCmdFire,
                GameMatcher.ComponentsView
            ));
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities) {
                var fireCmd = gameEntity.componentsCmdFire;
                gameEntity.RemoveComponentsCmdFire();

                var playerView = (PlayerView)gameEntity.componentsView.ViewGameObject;

                EntityUtil.CreateBulletEntity(_contexts, playerView.Shoot.position, fireCmd.Angle.Angle2Vector2D(), fireCmd.Angle);
            }
        }
    }
}