namespace ApiAuthAngular.Repository.Interface
{
    public interface IBaserepo<K,T>
    {
        T Add(T item);
        T Get(K key);
    }
}
