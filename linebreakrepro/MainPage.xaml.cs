using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace linebreakrepro;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    private string text;

    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged();
        }
    }
    
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;

        Text =
            "<p>Lorem <strong>ipsum dolor</strong> sit amet, consectetur <br><br>adipiscing elit, sed do eiusmod tempor incididunt ut labore <em>et dolore magna aliqua.</em> Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p><p><u>Duis aute irure dolor in reprehenderit in voluptate velit</u> esse cillum dolore eu fugiat nulla pariatur.</p><br><br><p>Excepteur sint occaecat cupidatat <strong>non proident</strong>, sunt in culpa qui officia deserunt mollit <br><em>anim id est laborum.</em></p>\n";
    }
}