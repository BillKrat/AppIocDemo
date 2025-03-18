namespace AOTE.Framework.CrossCutting.Interfaces
{
    public interface IAppLogger
    {
        void Log(string message);

        void Log(string message, Exception exception);

    }
}
