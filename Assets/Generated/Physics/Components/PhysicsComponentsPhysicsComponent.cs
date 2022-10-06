//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsContext {

    public PhysicsEntity componentsPhysicsEntity { get { return GetGroup(PhysicsMatcher.ComponentsPhysics).GetSingleEntity(); } }
    public Components.Physics componentsPhysics { get { return componentsPhysicsEntity.componentsPhysics; } }
    public bool hasComponentsPhysics { get { return componentsPhysicsEntity != null; } }

    public PhysicsEntity SetComponentsPhysics(System.Collections.Generic.List<Other.CollisionInfo> newCollisionInfos) {
        if (hasComponentsPhysics) {
            throw new Entitas.EntitasException("Could not set ComponentsPhysics!\n" + this + " already has an entity with Components.Physics!",
                "You should check if the context already has a componentsPhysicsEntity before setting it or use context.ReplaceComponentsPhysics().");
        }
        var entity = CreateEntity();
        entity.AddComponentsPhysics(newCollisionInfos);
        return entity;
    }

    public void ReplaceComponentsPhysics(System.Collections.Generic.List<Other.CollisionInfo> newCollisionInfos) {
        var entity = componentsPhysicsEntity;
        if (entity == null) {
            entity = SetComponentsPhysics(newCollisionInfos);
        } else {
            entity.ReplaceComponentsPhysics(newCollisionInfos);
        }
    }

    public void RemoveComponentsPhysics() {
        componentsPhysicsEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PhysicsEntity {

    public Components.Physics componentsPhysics { get { return (Components.Physics)GetComponent(PhysicsComponentsLookup.ComponentsPhysics); } }
    public bool hasComponentsPhysics { get { return HasComponent(PhysicsComponentsLookup.ComponentsPhysics); } }

    public void AddComponentsPhysics(System.Collections.Generic.List<Other.CollisionInfo> newCollisionInfos) {
        var index = PhysicsComponentsLookup.ComponentsPhysics;
        var component = (Components.Physics)CreateComponent(index, typeof(Components.Physics));
        component.CollisionInfos = newCollisionInfos;
        AddComponent(index, component);
    }

    public void ReplaceComponentsPhysics(System.Collections.Generic.List<Other.CollisionInfo> newCollisionInfos) {
        var index = PhysicsComponentsLookup.ComponentsPhysics;
        var component = (Components.Physics)CreateComponent(index, typeof(Components.Physics));
        component.CollisionInfos = newCollisionInfos;
        ReplaceComponent(index, component);
    }

    public void RemoveComponentsPhysics() {
        RemoveComponent(PhysicsComponentsLookup.ComponentsPhysics);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PhysicsMatcher {

    static Entitas.IMatcher<PhysicsEntity> _matcherComponentsPhysics;

    public static Entitas.IMatcher<PhysicsEntity> ComponentsPhysics {
        get {
            if (_matcherComponentsPhysics == null) {
                var matcher = (Entitas.Matcher<PhysicsEntity>)Entitas.Matcher<PhysicsEntity>.AllOf(PhysicsComponentsLookup.ComponentsPhysics);
                matcher.componentNames = PhysicsComponentsLookup.componentNames;
                _matcherComponentsPhysics = matcher;
            }

            return _matcherComponentsPhysics;
        }
    }
}