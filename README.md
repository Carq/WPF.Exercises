# Zadanie 2. - Obsługa zdarzeń

## 2.1 Wyświetl spis samochodów według poniższego mocka:

![2.1](https://i.ibb.co/WVKBhLN/E02-01.png)

- MainViewModel posiada teraz właściwość która jest kolekcją obiektów CarDto typu ObservableCollection - jest ona odpowiedzialna za odświeżanie widoku gdy element zostanie dodany lub usunięty
- Użyj kontroli DataGrid (opis w Cheet Scheet)
- Wiersze DataGrid nie powinny być edytowalny

### 2.2 Dodaj Command do przycisków Clear i Load

- Przycisk Clear powinnien usuwać wszystkie samochody z listy
- Przycisk Load powinnien ładować liste samochodów na nowo
- Co się dzieje gdy nadpiszamy w ViewModel właściowośc Cars? Dlaczego tak się dzieje?

### 2.4 Przyciski Load i Clean powinny się wyszarzać w określonych warunkach

- Clear ma się wyszarzyć gdy lista samochodów nie jest pusta
- Load ma się wyszczrzyć gdy lista samochodów posiada chodź jeden element

### 2.5 Dodaj Command do przycisku Add Car

- Przycisk Add Car powinnien dodawać nowy samochód do DataGrid (na razie niech dodaje z zahardcodowanymi danymi)

# Cheat sheet

## Kontrolka DataGrid

Kolekcje bindujemy do właściwości ItemsSource

```xml
<DataGrid
    AutoGenerateColumns="False"
    IsReadOnly="True"
    ItemsSource="{Binding ...}"
    SelectionMode="Single">
    <DataGrid.Columns>
        <DataGridTextColumn
            Width="30"
            Binding="{Binding Name}"
            Header="Header Name" />
        <DataGridCheckBoxColumn Binding="{Binding IsBool}" Header="Is bool" />
    </DataGrid.Columns>
</DataGrid>
```

## Użycie commandów

ViewModel

```csharp
using GalaSoft.MvvmLight.Command;
...
public RelayCommand CleanCommand { get; }
...
DoThisCommand = new RelayCommand(DoThis);
...
private void DoThis()
{
    // Do this...
}
```

XAML

```xml
<Button Command="{Binding DoThisCommand, Mode=OneTime}" Content="Click me" />
```
