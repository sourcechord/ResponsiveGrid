# ResponsiveGrid
Responsive grid is a custom panel control for WPF/UWP.  
This library provides the grid layout system that is similar to Bootstrap framework.

### install

*Nuget Package*  
```
Install-Package ResponsiveGrid
```
https://www.nuget.org/packages/ResponsiveGrid/

## Usage 

### Preparation
Add xmlns to xaml code.

#### For WPF
```xml
xmlns:rg="clr-namespace:SourceChord.ResponsiveGrid;assembly=ResponsiveGrid.Wpf"
```

#### For UWP
```xml
xmlns:rg="using:SourceChord.ResponsiveGrid"
```




## attention
ResponsiveGrid is not suitable for ItemsPanel, because it isn't implemented VirtualizingPanel class.

If you use ResponsiveGrid in ListBox as ItemsPanel.
Your ListBox become to not virtualize items of ListBox.

## Lisence
[MIT](LICENSE)
