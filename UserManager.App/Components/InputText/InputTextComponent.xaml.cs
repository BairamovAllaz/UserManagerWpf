using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
namespace UserManager.App.Components.InputText;
public partial class InputTextComponent : UserControl,INotifyPropertyChanged
{
    private string _label;
    public string LabelContent
    {
        get => _label;
        set
        {
            if (value is null) return;
            if (value == _label) return;
            _label = value;
            OnPropertyChanged(nameof(LabelContent));
        }
    }
    private string _input;
    public string InputText
    {
        get => _input;
        set
        {
            if (value is null) return;
            if (value == _label) return;
            _input = value;
            OnPropertyChanged(nameof(InputText));
        }
    }
    public InputTextComponent()
    {
        InitializeComponent();
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}