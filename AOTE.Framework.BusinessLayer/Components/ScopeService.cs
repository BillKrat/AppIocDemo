using Microsoft.Extensions.DependencyInjection;

namespace AppIocDemo.LayerBusiness.Components
{
    public class ScopeService(IServiceScopeFactory scopeFactory)
        : IDisposable
    {
        private IServiceScope? scope1, scope2;
        public Tuple<ScopedUser?, ScopedUser?> GetTwoScopedUsers()
        {
            scope1 = scopeFactory.CreateScope();
            scope2 = scopeFactory.CreateScope();
            var user1 = scope1.ServiceProvider.GetService<ScopedUser>();
            var user2 = scope2.ServiceProvider.GetService<ScopedUser>();
            return new(user1, user2);
        }
        #region Disposable pattern
        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                scope1?.Dispose();
                scope2?.Dispose();
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
