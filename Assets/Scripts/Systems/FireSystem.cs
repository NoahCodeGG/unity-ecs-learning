using System.Collections.Generic;
using Entitas;
using Hybrid;
using Managers;
using Other;
namespace Systems
{
    public class FireSystem : ReactiveSystem<GameEntity>
    {

        private readonly Contexts _contexts;

        public FireSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.AllOf(
                GameMatcher.ComponentsPlayerTag,
                GameMatcher.ComponentsFireCmd,
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
                var fireCmd = gameEntity.componentsFireCmd;
                gameEntity.RemoveComponentsFireCmd();

                var playerView = (PlayerView)gameEntity.componentsView.ViewGameObject;

                EntityUtil.CreateBulletEntity(_contexts, playerView.shoot.position, fireCmd.Angle.Angle2Vector2D(), fireCmd.Angle);
            }
        }
    }
}