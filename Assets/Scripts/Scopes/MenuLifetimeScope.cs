using ImpressiveGame.Controller;
using ImpressiveGame.Views;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace ImpressiveGame.Scopes
{
    public class MenuLifetimeScope : LifetimeScope
    {
        [SerializeField] private MenuView _menuView;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<MenuController>();
            builder.RegisterComponent(_menuView);
        }
    }
}
