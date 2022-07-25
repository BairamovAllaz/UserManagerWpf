namespace UserManager.Models;

public class Account : IEquatable<Account>
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public bool IsActive { get; set; }

    public bool Equals(Account? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Login == other.Login && Password == other.Password && RoleId == other.RoleId && IsActive == other.IsActive;
    }
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Account)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Login, Password, RoleId, IsActive);
    }
}