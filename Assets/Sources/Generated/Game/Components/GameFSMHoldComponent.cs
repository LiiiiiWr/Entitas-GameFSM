//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public FSMHoldComponent fSMHold { get { return (FSMHoldComponent)GetComponent(GameComponentsLookup.FSMHold); } }
    public bool hasFSMHold { get { return HasComponent(GameComponentsLookup.FSMHold); } }

    public void AddFSMHold(string newReason) {
        var index = GameComponentsLookup.FSMHold;
        var component = CreateComponent<FSMHoldComponent>(index);
        component.reason = newReason;
        AddComponent(index, component);
    }

    public void ReplaceFSMHold(string newReason) {
        var index = GameComponentsLookup.FSMHold;
        var component = CreateComponent<FSMHoldComponent>(index);
        component.reason = newReason;
        ReplaceComponent(index, component);
    }

    public void RemoveFSMHold() {
        RemoveComponent(GameComponentsLookup.FSMHold);
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

    static Entitas.IMatcher<GameEntity> _matcherFSMHold;

    public static Entitas.IMatcher<GameEntity> FSMHold {
        get {
            if (_matcherFSMHold == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.FSMHold);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFSMHold = matcher;
            }

            return _matcherFSMHold;
        }
    }
}
