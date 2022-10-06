using UnityEngine;
namespace Hybrid
{
    public interface IPhysicsView : IView
    {
        Rigidbody2D Rigidbody { get; }
    }
}