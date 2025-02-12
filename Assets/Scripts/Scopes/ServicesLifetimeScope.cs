using ImpressiveGame.Services;
using ImpressiveGame.Views;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ImpressiveGame.Scopes
{
    public class ServicesLifetimeScope : LifetimeScope
    {
        [SerializeField] private LoadingScreenView _loadingScreenView;
        [SerializeField] private ServiceView _serviceView;

        protected override void Configure(IContainerBuilder builder)
        {
            //MonoBehaviour
            builder.RegisterComponent(_loadingScreenView);
            builder.RegisterComponent(_serviceView);
            
            //Register
            builder.Register<SceneLoader>(Lifetime.Singleton);
            builder.Register<InitializationQueue>(Lifetime.Singleton);
            builder.Register<ScreenService>(Lifetime.Singleton).AsSelf();
            
            //RegisterEntryPoint
            builder.RegisterEntryPoint<ServicesStartup>();
            
        }
    }
}