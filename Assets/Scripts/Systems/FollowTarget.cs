using Entitas;
using Other;
namespace Systems
{
    public class FollowTarget : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _group;

        public FollowTarget(Contexts contexts)
        {
            _contexts = contexts;
            _group = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.ComponentsTarget,
                GameMatcher.ComponentsVelocity,
                GameMatcher.ComponentsPosition
            ));
        }

        public void Execute()
        {
            foreach (var gameEntity in _group.GetEntities()) {
                var targetEntity = _contexts.game.GetEntityWithComponentsId(gameEntity.componentsTarget.TargetId);

                var targetObjPosition = targetEntity.componentsPosition.Value;
                var selfPosition = gameEntity.componentsPosition.Value;

                var dirVector = (targetObjPosition - selfPosition).normalized;

                // TODO 修改敌人追踪主角速度
                gameEntity.ReplaceComponentsRotation(dirVector.Vector2D2Angle());
                gameEntity.ReplaceComponentsVelocity(dirVector*5);
            }
        }
    }
}