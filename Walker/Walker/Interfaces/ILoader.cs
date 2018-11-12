namespace Walker.Interfaces
{
    public interface ILoader<T> where T : class
    {
        T Load();
    }
}
