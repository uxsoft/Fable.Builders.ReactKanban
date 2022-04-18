# Fable.ReactKanban

React Kanban bindings for Fable React

<img src="https://buildstats.info/nuget/Fable.ReactKanban" alt="badge"/>

## Usage 

### Dependencies:

```bash
yarn add @asseinfo/react-kanban
```

```bash
dotnet package add Fable.ReactKanban
```

### Fable

```fsharp
KanbanBoard<KBoard, KColumn, KCard> {
    disableColumnDrag true
    style [ style.width (length.percent 100); style.height 3000 ]
    onCardDragEnd (fun card source destination ->
        onChangeStatus app card.id destination.toColumnId)
    renderCard (fun (card) props ->
        div { str card.title })
    children (mapBoard app level)
}
```
