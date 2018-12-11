# Zadanie 1. - Binding i kontrolki

## 1.1 Wyświetl informacje o samochodzie na MainWindow według poniższego mocka:

![1.1](https://i.ibb.co/SKMvrXP/E01-01.png)

## 1.2 Uaktualnij Header (Mondeo, Ford) po zmianie wartości w TextBoxach

## 1.3 Po kliknięciu w guzik "About" otwórz okno About

## \*1.4 Pole "Date of last inspection" wyświetl w formacie dd.MM.yyyy - robiąc zmiany tylko w pliku .xaml

# Cheat sheet

## Podstawowe kontrolki

```xml
<TextBlock Margin="5" HorizontalAlignment="Right" Text="Hello wordld" />

<TextBox Text="{Binding DateOfLastInspection, Mode=OneWay" />

<CheckBox IsChecked="{Binding IsUsed}" />

<Button Width="100" Height="30" Content="Click me" />
```

## Kontrolki grupujące

```xml
<StackPanel Orientation="Vertical">
    <Image Height="300" Source="/WPF.Exercises;component/..." />
    <Label HorizontalAlignment="Center" Content="WPF Traning 2018" />
</StackPanel>
```

```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="350" />
        <RowDefinition Height="auto" />
    </Grid.RowDefinitions>

    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
    </Grid.ColumnDefinitions>

    <Image
        Grid.ColumnSpan="2"
        Margin="5"
        Source="{Binding Photo}" />

    <TextBlock
        Grid.Row="1"
        Grid.Column="0"
        HorizontalAlignment="Center"
        FontSize="16"
        FontWeight="Bold"
        Text="{Binding Name}" />

    <Button
        Grid.Row="1"
        Grid.Column="1"
        Width="100"
        Height="30"
        Margin="5"
        Content="Click me" />
</Grid>
```
