using System.Windows;
using UserManager.App.Windows.User;
using UserManager.Models.Table;

namespace UserManager.App.Windows.Authorization;

public partial class AuthorizationWindow : Window
{
    public AuthorizationWindow()
    {
        InitializeComponent();
    }

    private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
    {
        InputLogin.Clear();
        InputPassword.Clear();
    }

    private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
    {
        var login = InputLogin.Text;
        var password = InputPassword.Password;
        var accounts = new TableAccount().GetTable();
        var account = accounts.Find(a => a.Login == login && a.Password == password);
        if (account is null)
        {
            MessageBox.Show("Login or Password is incorrect","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            return;
        }
        MessageBox.Show("User Founded Welcome Home","Info",MessageBoxButton.OK,MessageBoxImage.Information);
        var role = new TableRole().GetTable().Find(r => r.Id == account.RoleId)?.Name;

        switch (role)
        {
            case "admin":
                new UserWinodow().Show();
                break;
            case "user":
                break; 
        }
    }
}