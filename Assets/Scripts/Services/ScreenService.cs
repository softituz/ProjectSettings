using Cysharp.Threading.Tasks;
using ImpressiveGame.Views;

namespace ImpressiveGame.Services
{
    public class ScreenService
    {
        private readonly LoadingScreenView _screenView;
        private readonly ServiceView _serviceView;

        public ScreenService(LoadingScreenView screenView, ServiceView serviceView)
        {
            _screenView = screenView;
            _serviceView = serviceView;
        }

        public async UniTask ShowLoadingScreenAsync()
        {
            _serviceView.OnCamera();
            _screenView.ToggleLoadingScreen(true);
            await UniTask.CompletedTask;
        }

        public async UniTask HideLoadingScreenAsync()
        {
            _serviceView.OffCamera();
            _screenView.ToggleLoadingScreen(false);
            await UniTask.CompletedTask;
        }
    }
}