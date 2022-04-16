namespace Fable.Builders.ReactKanban

open System
open Fable.Builders.Common
open Fable.React
open Fable.Core.JsInterop

type KanbanBuilder<'TBoard, 'TColumn, 'TCard>() =
    inherit ReactBuilder(import "default" "@asseinfo/react-kanban")
    
    [<CustomOperation("initialBoard")>] member inline _.initialBoard (x: DSLElement, v: 'TBoard) = x.attr "initialBoard" v
    [<CustomOperation("onCardDragEnd")>] member inline _.onCardDragEnd (x: DSLElement, v: Func<'TCard, {| fromColumnId: int; fromPosition: int |}, {| toColumnId: int; toPosition: int |}, unit>) = x.attr "onCardDragEnd" v
    [<CustomOperation("onColumnDragEnd")>] member inline _.onColumnDragEnd (x: DSLElement, v: Func<'TColumn, {| fromPosition: int |}, {| toPosition: int |}, unit>) = x.attr "onColumnDragEnd" v
    [<CustomOperation("renderCard")>] member inline _.renderCard (x: DSLElement, v: Func<'TCard, obj, ReactElement>) = x.attr "renderCard" v
    [<CustomOperation("renderColumnHeader")>] member inline _.renderColumnHeader (x: DSLElement, v: Func<'TColumn, {| removeColumn: unit -> unit; renameColumn: string -> unit; addCard: 'TCard -> unit |}, ReactElement>) = x.attr "renderColumnHeader" v
    [<CustomOperation("allowAddColumn")>] member inline _.allowAddColumn (x: DSLElement, v: bool) = x.attr "allowAddColumn" v
    [<CustomOperation("onNewColumnConfirm")>] member inline _.onNewColumnConfirm (x: DSLElement, v: Func<'TColumn, 'TColumn>) = x.attr "onNewColumnConfirm" v
    [<CustomOperation("onColumnNew")>] member inline _.onColumnNew (x: DSLElement, v: Func<'TColumn, 'TColumn>) = x.attr "onColumnNew" v
    [<CustomOperation("renderColumnAdder")>] member inline _.renderColumnAdder (x: DSLElement, v: {| addColumn: 'TColumn -> unit |}) = x.attr "renderColumnAdder" v
    [<CustomOperation("disableColumnDrag")>] member inline _.disableColumnDrag (x: DSLElement, v: bool) = x.attr "disableColumnDrag" v
    [<CustomOperation("disableCardDrag")>] member inline _.disableCardDrag (x: DSLElement, v: bool) = x.attr "disableCardDrag" v
    [<CustomOperation("allowRemoveColumn")>] member inline _.allowRemoveColumn (x: DSLElement, v: bool) = x.attr "allowRemoveColumn" v
    [<CustomOperation("onColumnRemove")>] member inline _.onColumnRemove (x: DSLElement, v: Func<'TBoard, 'TColumn, unit>) = x.attr "onColumnRemove" v
    [<CustomOperation("allowRenameColumn")>] member inline _.allowRenameColumn (x: DSLElement, v: bool) = x.attr "allowRenameColumn" v
    [<CustomOperation("onColumnRename")>] member inline _.onColumnRename (x: DSLElement, v: Func<'TBoard, 'TColumn, unit>) = x.attr "onColumnRename" v
    [<CustomOperation("allowRemoveCard")>] member inline _.allowRemoveCard (x: DSLElement, v: bool) = x.attr "allowRemoveCard" v
    [<CustomOperation("onCardRemove")>] member inline _.onCardRemove (x: DSLElement, v: Func<'TBoard, 'TColumn, 'TCard>) = x.attr "onCardRemove" v
    [<CustomOperation("allowAddCard")>] member inline _.allowAddCard (x: DSLElement, v: bool) = x.attr "allowAddCard" v
    [<CustomOperation("onCardNew")>] member inline _.onCardNew (x: DSLElement, v: Func<'TCard, 'TCard>) = x.attr "onCardNew" v
    [<CustomOperation("onNewCardConfirm")>] member inline _.onNewCardConfirm (x: DSLElement, v: Func<'TCard, 'TCard>) = x.attr "onNewCardConfirm" v
    
    [<CustomOperation("children")>] member inline _.children (x: DSLElement, v: 'TBoard) = x.attr "children" v