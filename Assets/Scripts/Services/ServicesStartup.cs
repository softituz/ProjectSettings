using System.Threading;
using Cysharp.Threading.Tasks;
using ImpressiveGame.Scopes;
using VContainer.Unity;

namespace ImpressiveGame.Services
{
    public class ServicesStartup : IAsyncStartable
    {
        private readonly SceneLoader _sceneLoader;

        public ServicesStartup(SceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        
        public async UniTask StartAsync(CancellationToken cancellation)
        {
            await _sceneLoader.LoadMenuAsync();
        }
    }
}