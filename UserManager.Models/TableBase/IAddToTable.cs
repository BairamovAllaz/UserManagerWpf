namespace UserManager.Models.TableBase;

public interface IAddToTable<in T>
{
    public int AddToTable(T obj);
}