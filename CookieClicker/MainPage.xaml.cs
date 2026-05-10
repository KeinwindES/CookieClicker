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
    private int _cps = 0;

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

    public int CPS {
        get => _cps; 
        set { _cps = value; OnPropertyChanged(); } 
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
    public void OnBuyClicker(object? sender, EventArgs e) {
        if (Cookie >= 1) {
            Cookie--;
            Clicker++;
            CPS++;
            SemanticScreenReader.Announce($"Clicked {Clicker} times");

        }
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    public void OnBuyMelon(object? sender, EventArgs e) {
        if (Cookie >= 50) {
            Cookie = Cookie -50;
            Melon++;
            CPS = CPS + 5;
            SemanticScreenReader.Announce($"Clicked {Clicker} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    public void OnBuyTable(object? sender, EventArgs e) {
        if (Cookie >= 100) {
            Cookie = Cookie -100;
            Table++;
            CPS = CPS + 10;

            SemanticScreenReader.Announce($"Clicked {Table} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    public void OnBuyStand(object? sender, EventArgs e) {
        if (Cookie >= 500) {
            Cookie = Cookie -500;
            Stand++;
            CPS = CPS + 20;
            SemanticScreenReader.Announce($"Clicked {Stand} times");

        }
        
        SemanticScreenReader.Announce($"Clicked {Cookie} times");
    }
    
    public async void StartGameLoop()
    {
        bool isGameRunning = true;

        while (isGameRunning)
        {
            // 1. Logic: Add cookies
            Cookie += CPS;

            // 2. UI: Update the screen
            SemanticScreenReader.Announce($"Clicked {Cookie} times");

            // 3. Wait: This lets the UI "breathe" for 1 second
            await Task.Delay(1000); 
        }
    }

    public new event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}