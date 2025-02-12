using ImpressiveGame.Scopes;
using ImpressiveGame.Views;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace ImpressiveGame.Controller
{
    public class MenuController : IInitializable
    {
        private readonly MenuView _menuView;
        private readonly SceneLoader _sceneLoader;

        public MenuController(MenuView menuView, SceneLoader sceneLoader)
        {
            _menuView = menuView;
            _sceneLoader = sceneLoader;
        }
        
        public void Initialize()
        {
            _menuView.GamePlayButton.onClick.AddListener(() =>
            {
                _sceneLoader.LoadGameAsync();
            });
            
            _menuView.ExitButton.onClick.AddListener(() =>
            {
                #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
                #else
                    Application.Quit();
                #endif
            });
        }
    }
}