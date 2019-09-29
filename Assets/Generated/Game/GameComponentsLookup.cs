//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int BoardSize = 0;
    public const int GridPosition = 1;
    public const int Id = 2;
    public const int IdCount = 3;
    public const int Drag = 4;
    public const int DragEnded = 5;
    public const int DragStarted = 6;
    public const int PieceInAir = 7;
    public const int PieceState = 8;
    public const int ReserveSlotForPiece = 9;
    public const int ReturnToReserveStarted = 10;
    public const int Position = 11;
    public const int Piece = 12;
    public const int PieceInReserve = 13;
    public const int ReserveSlot = 14;
    public const int ReserveSlotPositions = 15;
    public const int ReserveSlotState = 16;
    public const int Tile = 17;
    public const int TileState = 18;
    public const int View = 19;
    public const int AnyBoardSizeListener = 20;
    public const int DragEndedListener = 21;
    public const int DragStartedListener = 22;
    public const int GridPositionListener = 23;
    public const int PieceStateListener = 24;
    public const int PositionListener = 25;
    public const int ReserveSlotStateListener = 26;
    public const int ReturnToReserveStartedListener = 27;
    public const int TileStateListener = 28;

    public const int TotalComponents = 29;

    public static readonly string[] componentNames = {
        "BoardSize",
        "GridPosition",
        "Id",
        "IdCount",
        "Drag",
        "DragEnded",
        "DragStarted",
        "PieceInAir",
        "PieceState",
        "ReserveSlotForPiece",
        "ReturnToReserveStarted",
        "Position",
        "Piece",
        "PieceInReserve",
        "ReserveSlot",
        "ReserveSlotPositions",
        "ReserveSlotState",
        "Tile",
        "TileState",
        "View",
        "AnyBoardSizeListener",
        "DragEndedListener",
        "DragStartedListener",
        "GridPositionListener",
        "PieceStateListener",
        "PositionListener",
        "ReserveSlotStateListener",
        "ReturnToReserveStartedListener",
        "TileStateListener"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(_1010C.Scripts.Components.Board.BoardSizeComponent),
        typeof(_1010C.Scripts.Components.GridPositionComponent),
        typeof(_1010C.Scripts.Components.IdComponent),
        typeof(_1010C.Scripts.Components.IdCountComponent),
        typeof(_1010C.Scripts.Components.Piece.DragComponent),
        typeof(_1010C.Scripts.Components.Piece.DragEndedComponent),
        typeof(_1010C.Scripts.Components.Piece.DragStartedComponent),
        typeof(_1010C.Scripts.Components.Piece.PieceInAirComponent),
        typeof(_1010C.Scripts.Components.Piece.PieceStateComponent),
        typeof(_1010C.Scripts.Components.Piece.ReserveSlotForPieceComponent),
        typeof(_1010C.Scripts.Components.Piece.ReturnToReserveStartedComponent),
        typeof(_1010C.Scripts.Components.PositionComponent),
        typeof(_1010C.Scripts.Components.Reserve.PieceComponent),
        typeof(_1010C.Scripts.Components.Reserve.PieceInReserveComponent),
        typeof(_1010C.Scripts.Components.Reserve.ReserveSlotComponent),
        typeof(_1010C.Scripts.Components.Reserve.ReserveSlotPositionsComponent),
        typeof(_1010C.Scripts.Components.Reserve.ReserveSlotStateComponent),
        typeof(_1010C.Scripts.Components.Tile.TileComponent),
        typeof(_1010C.Scripts.Components.Tile.TileStateComponent),
        typeof(_1010C.Scripts.Components.ViewComponent),
        typeof(AnyBoardSizeListenerComponent),
        typeof(DragEndedListenerComponent),
        typeof(DragStartedListenerComponent),
        typeof(GridPositionListenerComponent),
        typeof(PieceStateListenerComponent),
        typeof(PositionListenerComponent),
        typeof(ReserveSlotStateListenerComponent),
        typeof(ReturnToReserveStartedListenerComponent),
        typeof(TileStateListenerComponent)
    };
}
