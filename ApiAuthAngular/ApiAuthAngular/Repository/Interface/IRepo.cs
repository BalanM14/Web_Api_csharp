namespace ApiAuthAngular.Repository.Interface
{
    public interface IRepo<K, T> : IBaserepo<K, T>
    {
        ICollection<T> GetAll();
        T Update(T item);
        T Delete(K key);
    }
}
