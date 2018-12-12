# Zadanie 6. - Style

## 6.1 Stwórz styl dla wszystkich guzików w MainWindow:

- Czarne tło, biała czcionka, tekst zawsze wyśrodkowany

# Cheat sheet

## Definiowanie stylów

```xml
<Window.Resources>
    <Style TargetType="{x:Type Button}">
        <Setter Property="FontSize" Value="17" />
    </Style>
</Window.Resources>
```

## Przykład nadpisania wyglądu Buttona z obsługą zdarzeń gdy guzik jest przyciśnięty

```xml
<DropShadowEffect
        x:Key="DropShadowEffect"
        BlurRadius="3"
        Direction="-90"
        ShadowDepth="0.5" />

<Style TargetType="{x:Type Button}">
    <Setter Property="Effect" Value="{StaticResource DropShadowEffect}" />
    <Setter Property="RenderTransformOrigin" Value="0.5, 0.5" />
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="{x:Type Button}">
                <Border
                    x:Name="ButtonBorder"
                    Background="{TemplateBinding Background}"
                    CornerRadius="5">
                    <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center" />
                </Border>
                <ControlTemplate.Triggers>
                    <Trigger Property="IsPressed" Value="True">
                        <Setter Property="RenderTransform">
                            <Setter.Value>
                                <TransformGroup>
                                    <ScaleTransform ScaleX="0.95" ScaleY="0.95" />
                                </TransformGroup>
                            </Setter.Value>
                        </Setter>
                    </Trigger>
                    <Trigger Property="IsEnabled" Value="False">
                        <Setter TargetName="ButtonBorder" Property="Background" Value="DarkGray" />
                    </Trigger>
                </ControlTemplate.Triggers>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
