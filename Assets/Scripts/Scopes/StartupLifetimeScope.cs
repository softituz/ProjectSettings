using ImpressiveGame.Services;
using VContainer;
using VContainer.Unity;

namespace ImpressiveGame.Scopes
{
    public class StartupLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<Startup>();
        }
    }
}