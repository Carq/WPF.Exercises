# Zadanie 3. - Walidacja danych

## 3.1 W nowym oknie AddNewCar zaimplementuj funkcjonalność dodawania nowego samochodu

- Po kliknieciu przycisku Add Car na MainWindow otwórz nowe okno AddNewCar (użyj klasy SimpleNavigationService)
- Zwróć szczególną uwagę na właściwość DateOfLastInspection (co jest domyślnie wyświetlane na widoku po otwarciu okna?)
- Zaimplementuj klase AddNewCarViewModel (widok jest już gotowy) tak aby po kliknięciu Save dodawało nowy samochód
- Lista samochodów powinna się odświeżyć po zamknieciu okna AddNewCar

## 3.2 Dodaj walidacje dla pól Brand i Model

- Użyj interface IDataErrorInfo w klasie AddNewCarViewModel
- Ustaw różne wartości UpdateSourceTrigger przy bindingu, kiedy walidacja jest odpalana?
- Przy niepoprawnych danych guzik Save powinnien być wyszarzony

## \*3.3 Jeżeli zapis w FleetService się nie powiedzie wyświetl komunikat o błedzie

- W jaki sposób można to zrobić aby nie używać bezpośrednio MessageBox w ViewModelu?

## \*3.4 Usuń zależność na klase Window w AddNewCarViewModel (SaveCommand)

# Cheat sheet

## Włączenie walidacji w XAML

```xml
<TextBox Text="{Binding Name, UpdateSourceTrigger=PropertyChanged, ValidatesOnDataErrors=True}" />
```

## DatePicker

```xml
<DatePicker SelectedDate="{Binding ..."/>
```
