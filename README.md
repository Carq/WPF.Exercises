# Zadanie 5. - Filtrowanie

## 5.1 Na MainWindow pozwól na filtrowanie samochodów

- Dodaj TextBox po lewej stronie guzików
- Dodaj filtrowanie po modelu, marce i dacie przeglądu

## 5.2 Użyj właściwości Delay dla bindingu

# Cheat sheet

## ListCollectionView

```csharp
ICollectionView collection = new ListCollectionView()
                                {
                                    Filter = ...
                                };
```

## Delay Binding

```xml
 <TextBox Text="{Binding Text, Delay=1000}" />
```
