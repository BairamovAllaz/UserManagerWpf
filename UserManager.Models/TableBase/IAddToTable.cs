namespace UserManager.Models.TableBase;

public interface IAddToTable<in T>
{
    public void AddToTable(T obj);
}