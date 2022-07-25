namespace UserManager.Models;

public class Role : IEquatable<Role>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public bool Equals(Role? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Role)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }
}