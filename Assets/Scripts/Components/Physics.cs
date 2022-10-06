using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using Other;
namespace Components
{
    [Physics]
    [Unique]
    public sealed class Physics : IComponent
    {
        public List<CollisionInfo> CollisionInfos;
    }
}