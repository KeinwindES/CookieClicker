using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CookieClicker;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private int _cookie = 0;
    public int Cookie 
    { 
        get => _cookie; 
        set { _cookie = value; OnPropertyChanged(); } 
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
        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    private void OnBuyMelon(object? sender, EventArgs e) {
        if (Cookie >= 5) {
            Cookie = Cookie -5;
        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    private void OnBuyTable(object? sender, EventArgs e) {
        if (Cookie >= 10) {
            Cookie = Cookie -10;

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