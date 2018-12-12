# Zadanie 4. - Konwertery

## 4.1 Stwórz konwerter zamieniejący date na kolor

- Na oknie AddNewCar zmieniaj kolor czcionki DatePickera w zależności od tego jak odległa data została wybrana dla DateOfLastInspection

## 4.2 Przekaż do Convertera parametr i użyj go

- Niech Converter w zależności od podanego parametru (typu bool) koloruje na różne sposoby (ciemniejsze kolory lub jaśniejsze).

# Cheat sheet

## Definiowanie convertera w XAML

```xml
<Window.Resources>
    <converters:NullToVisiblityConverter x:Key="NullToVisiblityConverter" />
</Window.Resources>
```

## Używanie Convertera

```xml
 <Button Visibility="{Binding IsActive, Converter={StaticResource NullToVisiblityConverter, ConverterParameter=true}}" />
```
