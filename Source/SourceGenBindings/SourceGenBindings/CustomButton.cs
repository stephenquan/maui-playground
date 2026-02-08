using CommunityToolkit.Maui;

namespace SourceGenBindings;

public partial class CustomButton : Button
{
    /*
    [BindableProperty]
    */
    public partial int? Number { get; set; }
    public partial int? Number
    {
        get => field;
        set { field = value; OnPropertyChanged(nameof(Number)); }
    }

    //
    // THIS WORKS:
    //
    // public static readonly BindableProperty NumberProperty = BindableProperty.Create(nameof(Number), typeof(int?), typeof(CustomButton));
    //
    // public int? Number
    // {
    //     get => (int)GetValue(NumberProperty);
    //     set => SetValue(NumberProperty, value);
    // }
    
}