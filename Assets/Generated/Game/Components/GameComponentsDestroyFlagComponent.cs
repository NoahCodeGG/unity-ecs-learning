//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Components.DestroyFlag componentsDestroyFlagComponent = new Components.DestroyFlag();

    public bool isComponentsDestroyFlag {
        get { return HasComponent(GameComponentsLookup.ComponentsDestroyFlag); }
        set {
            if (value != isComponentsDestroyFlag) {
                var index = GameComponentsLookup.ComponentsDestroyFlag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : componentsDestroyFlagComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherComponentsDestroyFlag;

    public static Entitas.IMatcher<GameEntity> ComponentsDestroyFlag {
        get {
            if (_matcherComponentsDestroyFlag == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ComponentsDestroyFlag);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherComponentsDestroyFlag = matcher;
            }

            return _matcherComponentsDestroyFlag;
        }
    }
}
