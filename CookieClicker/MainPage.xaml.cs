using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CookieClicker;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private int _cookie = 0;
    
    private int _clicker = 0;
    private int _melon = 0;
    private int _table = 0;
    private int _stand = 0;

    public int Cookie 
    { 
        get => _cookie; 
        set { _cookie = value; OnPropertyChanged(); } 
    }
    
    public int Clicker {
        get => _clicker; 
        set { _clicker = value; OnPropertyChanged(); } 
    }
    
    public int Melon {
        get => _melon; 
        set { _melon = value; OnPropertyChanged(); } 

    }
    
    public int Table {
        get => _table; 
        set { _table = value; OnPropertyChanged(); } 


    }

    public int Stand {
        get => _stand; 
        set { _stand = value; OnPropertyChanged(); } 


    }
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this; // Required to link XAML to this class
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        Cookie++;
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    //  Upgrades
    private void OnBuyClicker(object? sender, EventArgs e) {
        if (Cookie >= 1) {
            Cookie--;
            Clicker++;
            SemanticScreenReader.Announce($"Clicked {Clicker} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    private void OnBuyMelon(object? sender, EventArgs e) {
        if (Cookie >= 5) {
            Cookie = Cookie -5;
            Melon++;
            SemanticScreenReader.Announce($"Clicked {Clicker} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    private void OnBuyTable(object? sender, EventArgs e) {
        if (Cookie >= 10) {
            Cookie = Cookie -10;
            Table++;
            SemanticScreenReader.Announce($"Clicked {Table} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    private void OnBuyStand(object? sender, EventArgs e) {
        if (Cookie >= 20) {
            Cookie = Cookie -20;
        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}