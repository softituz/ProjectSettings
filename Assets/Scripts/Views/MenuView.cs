using UnityEngine;
using UnityEngine.UI;

namespace ImpressiveGame.Views
{
    public class MenuView: MonoBehaviour
    {
        [SerializeField] private Button _gameplayButton; //start button
        //[SerializeField] private Button _settingsButton; 
        //[SerializeField] private Button _achivementButton;
        //[SerializeField] private Button _continueButton;
        [SerializeField] private Button _exitButton;
        
        public Button GamePlayButton => _gameplayButton;
        //public Button SettingsButton => _settingsButton;
        //public Button AchivementButton => _achivementButton;
        //public Button ContinueButton => _continueButton;
        public Button ExitButton => _exitButton;
    }
}