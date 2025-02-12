using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ImpressiveGame.Scopes
{
    public class GameplayLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Views
            //builder.RegisterComponent(_playerMovementView);
            

            // Register
            //builder.Register<PlayerModel>(Lifetime.Scoped);
            

            // Register EntryPoints
            //builder.RegisterEntryPoint<PlayerMovement>(Lifetime.Scoped);
        }
    }
}