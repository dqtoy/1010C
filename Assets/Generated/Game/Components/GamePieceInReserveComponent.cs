//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _1010C.Components.Reserve.PieceInReserveComponent pieceInReserve { get { return (_1010C.Components.Reserve.PieceInReserveComponent)GetComponent(GameComponentsLookup.PieceInReserve); } }
    public bool hasPieceInReserve { get { return HasComponent(GameComponentsLookup.PieceInReserve); } }

    public void AddPieceInReserve(int newId) {
        var index = GameComponentsLookup.PieceInReserve;
        var component = (_1010C.Components.Reserve.PieceInReserveComponent)CreateComponent(index, typeof(_1010C.Components.Reserve.PieceInReserveComponent));
        component.Id = newId;
        AddComponent(index, component);
    }

    public void ReplacePieceInReserve(int newId) {
        var index = GameComponentsLookup.PieceInReserve;
        var component = (_1010C.Components.Reserve.PieceInReserveComponent)CreateComponent(index, typeof(_1010C.Components.Reserve.PieceInReserveComponent));
        component.Id = newId;
        ReplaceComponent(index, component);
    }

    public void RemovePieceInReserve() {
        RemoveComponent(GameComponentsLookup.PieceInReserve);
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

    static Entitas.IMatcher<GameEntity> _matcherPieceInReserve;

    public static Entitas.IMatcher<GameEntity> PieceInReserve {
        get {
            if (_matcherPieceInReserve == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PieceInReserve);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPieceInReserve = matcher;
            }

            return _matcherPieceInReserve;
        }
    }
}
