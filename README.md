# Zadanie 3. - Walidacja danych

## 3.1 W nowym oknie AddNewCar zaimplementuj funkcjonalność dodawania nowego samochodu.

- Po kliknieciu przycisku Add Car na MainWindow otwórz nowe okno AddNewCar
- Zaimplementuj klase AddNewCarViewModel (widok jest już gotowy) tak aby po kliknięciu Save dodawało nowy samochód
- Lista samochodów powinna się odświeżyć po zamknieciu okna AddNewCar

## 3.2 Dodaj walidacje dla pól Brand i Model

- Użyj interface IDataErrorInfo w klasie AddNewCarViewModel
- Przy nie poprawnych danych guzik Save powinnien być wyszarzony

## \*3.3 Usuń zależność na klase Window w AddNewCarViewModel (SaveCommand)

# Cheat sheet

## Włączenie walidacji w XAML

```xml
<TextBox Text="{Binding Name, ValidatesOnDataErrors=True}" />
```
