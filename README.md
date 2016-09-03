# XamarinFormsBindingSimple
Most simple(?) data binding sample

## Pickuped code
### Page1.xaml
```xml
  ....
  <Label Text="{Binding MainText}" .... /> <!-- BINDING TARGET -->
  <Button Text="Add!" Clicked="Button_Clicked" />
  ....
```

### Page1.xaml.cs
```cs
public partial class Page1 : ContentPage
{
    public string MainText { get; set; } = "Hello";

    public Page1()
    {
        InitializeComponent();
        this.BindingContext = this; // BINDING SOURCE
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // CHANGE BINDING PROPERTY
        this.MainText += "!";
        this.OnPropertyChanged("MainText");
    }
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsBindingSimple/master/screenshots/screenshot.png)
