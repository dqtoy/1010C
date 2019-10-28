//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _1010C.Scripts.Components.Piece.PieceCubePositions pieceCubePositions { get { return (_1010C.Scripts.Components.Piece.PieceCubePositions)GetComponent(GameComponentsLookup.PieceCubePositions); } }
    public bool hasPieceCubePositions { get { return HasComponent(GameComponentsLookup.PieceCubePositions); } }

    public void AddPieceCubePositions(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.PieceCubePositions;
        var component = (_1010C.Scripts.Components.Piece.PieceCubePositions)CreateComponent(index, typeof(_1010C.Scripts.Components.Piece.PieceCubePositions));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePieceCubePositions(UnityEngine.Vector2[] newValue) {
        var index = GameComponentsLookup.PieceCubePositions;
        var component = (_1010C.Scripts.Components.Piece.PieceCubePositions)CreateComponent(index, typeof(_1010C.Scripts.Components.Piece.PieceCubePositions));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePieceCubePositions() {
        RemoveComponent(GameComponentsLookup.PieceCubePositions);
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

    static Entitas.IMatcher<GameEntity> _matcherPieceCubePositions;

    public static Entitas.IMatcher<GameEntity> PieceCubePositions {
        get {
            if (_matcherPieceCubePositions == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PieceCubePositions);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPieceCubePositions = matcher;
            }

            return _matcherPieceCubePositions;
        }
    }
}
