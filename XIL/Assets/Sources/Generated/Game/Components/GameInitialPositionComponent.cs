//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public InitialPositionComponent initialPosition { get { return (InitialPositionComponent)GetComponent(GameComponentsLookup.InitialPosition); } }
    public bool hasInitialPosition { get { return HasComponent(GameComponentsLookup.InitialPosition); } }

    public void AddInitialPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.InitialPosition;
        var component = (InitialPositionComponent)CreateComponent(index, typeof(InitialPositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInitialPosition(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.InitialPosition;
        var component = (InitialPositionComponent)CreateComponent(index, typeof(InitialPositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInitialPosition() {
        RemoveComponent(GameComponentsLookup.InitialPosition);
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

    static Entitas.IMatcher<GameEntity> _matcherInitialPosition;

    public static Entitas.IMatcher<GameEntity> InitialPosition {
        get {
            if (_matcherInitialPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InitialPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInitialPosition = matcher;
            }

            return _matcherInitialPosition;
        }
    }
}