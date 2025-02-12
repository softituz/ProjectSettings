using UnityEngine;

namespace ImpressiveGame.Views
{
    public class LoadingScreenView : MonoBehaviour
    {
        public void ToggleLoadingScreen(bool value)
        {
            gameObject.SetActive(value);
        }
    }
}