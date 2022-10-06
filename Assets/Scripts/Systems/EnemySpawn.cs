using Entitas;
using Managers;
using UnityEngine;
namespace Systems
{
    public class EnemySpawn : IExecuteSystem
    {

        private readonly Contexts _contexts;
        private float _timer = 0f;
        
        public EnemySpawn(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            _timer += Time.deltaTime;

            if (_timer >= 1f) {
                _timer = 0;

                var x = Random.Range(-9f, 9f);
                var y = Random.Range(-5f, 5f);

                var enemyEntity = EntityUtil.CreateEnemyEntity(
                    _contexts,
                    new Vector2(x, y),
                    Vector2.zero,
                    0f
                );

                var playerEntity = _contexts.game.componentsTagsPlayerEntity;
                enemyEntity.AddComponentsTarget(playerEntity.componentsId.Value);
            }
        }
    }
}