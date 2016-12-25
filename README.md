# ResponsiveGrid

**This project has been moved to GridExtra**  
https://github.com/sourcechord/GridExtra

ResponsiveGrid is a custom panel control for WPF/UWP.  
This library provides the grid layout system that is similar to Bootstrap framework.

![demo](./docs/Demo.gif)

## features
* ResponsiveGrid class 
    * Custom Panel class that provides bootstrap like grid system.
* Grid system
    * switch layout with window width.
         * XS(<768px), SM(<992px), MD(<1200px), LG(1200px<=)
    * 12 columns across the page.(customizable with MaxDivision property)


## Usage
### install

*Nuget Package*  
```
Install-Package ResponsiveGrid
```
https://www.nuget.org/packages/ResponsiveGrid/

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

#### Getting Started
```xml
    <Grid>
        <Grid.Resources>
            <Style TargetType="{x:Type Border}">
                <Setter Property="BorderBrush" Value="Black" />
                <Setter Property="BorderThickness" Value="1" />
                <Setter Property="Background" Value="LightGray" />
                <Setter Property="Height" Value="60" />
            </Style>
        </Grid.Resources>
        <rg:ResponsiveGrid>
            <Border rg:ResponsiveGrid.XS="12" rg:ResponsiveGrid.SM="3" />
            <Border rg:ResponsiveGrid.XS="12" rg:ResponsiveGrid.SM="6" />
            <Border rg:ResponsiveGrid.XS="12" rg:ResponsiveGrid.SM="3" />
        </rg:ResponsiveGrid>
    </Grid>
```
*extra small device(~768px)*  
![extra small device](./docs/capture1.png)

*small device(~992px)*  
![small device](./docs/capture2.png)

#### Properties

##### Dependency Properties
|Property Name|Type|Description|
|-----|-----|-----|
|MaxDivision|int|Gets or sets a value that determines grid divisions.|
|BreakPoints|BreakPoints class||
|ShowGridLines|int|Gets or sets a value that indicates whether grid column's lines are visible within this ResponsiveGrid. |


##### Attached Properties

|Property Name|Type|Description|
|-----|-----|-----|
|XS<br/>SM<br/>MD<br/>LG<br/>|int|Gets or sets a value that determines grid columns for XS(extra small), SM(small), MD(medium), LG(large) devices.|
|XS_Offset<br/>SM_Offset<br/>MD_Offset<br/>LG_Offset<br/>|int|Gets or sets a value that determines grid columns offset for XS(extra small), SM(small), MD(medium), LG(large) devices.|
|XS_Push<br/>SM_Push<br/>MD_Push<br/>LG_Push<br/>|int|Gets or sets a value that moves columns to right from the original position.|
|XS_Pull<br/>SM_Pull<br/>MD_Pull<br/>LG_Pull<br/>|int|Gets or sets a value that moves columns to left from the original position.|


##### Compared to bootstrap

|bootstrap|ResponsiveGrid|
|-----|-----|
|col-xs<br/>col-sm<br/>col-md<br/>col-lg<br/>|XS<br/>SM<br/>MD<br/>LG<br/>|
|col-xs-offset<br/>col-sm-offset<br/>col-md-offset<br/>col-lg-offset<br/>|XS_Offset<br/>SM_Offset<br/>MD_Offset<br/>LG_Offset<br/>|
|col-xs-push<br/>col-sm-push<br/>col-md-push<br/>col-lg-push<br/>|XS_Push<br/>SM_Push<br/>MD_Push<br/>LG_Push<br/>|
|col-xs-pull<br/>col-sm-pull<br/>col-md-pull<br/>col-lg-pull<br/>|XS_Pull<br/>SM_Pull<br/>MD_Pull<br/>LG_Pull<br/>|
|visibility-xs, visibility-sm,…<br />hidden-xs, hidden-sm,...|(T.B.D.)|



## attention
ResponsiveGrid is not suitable for ItemsPanel, because it isn't implemented VirtualizingPanel class.

If you use ResponsiveGrid in ListBox as ItemsPanel.
Your ListBox become to not virtualize items of ListBox.

## Lisence
[MIT](LICENSE)
