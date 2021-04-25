namespace Interface
{
    public interface IData<T>
    {
        void Save(T bonus, string path = null);
        T Load(string path = null);
    }
}