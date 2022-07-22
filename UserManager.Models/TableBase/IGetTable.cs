namespace UserManager.Models.TableBase;

public interface IGetTable<T>
{
    public List<T> GetTable();
}