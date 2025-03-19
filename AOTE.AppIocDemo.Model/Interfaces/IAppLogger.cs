namespace AppIocDemo.Model.Interfaces
{
    public interface IAppLogger
    {
        void Log(string message);

        void Log(string message, Exception exception);

    }
}
