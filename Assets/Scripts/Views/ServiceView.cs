using UnityEngine;

namespace ImpressiveGame.Views
{
    public class ServiceView: MonoBehaviour
    {
        [SerializeField] private Camera _camera;

        public void OffCamera()
        {
            _camera.gameObject.SetActive(false);
        }
        
        public void OnCamera()
        {
            _camera.gameObject.SetActive(true);
        }
    }
}