using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
    {
        #region Variables
        
        [Header("Screens")]
        [SerializeField] private GameObject _startScreen;
        [Header("Buttons")]
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _exitButtonStartScreen;
        #endregion


        #region Utity Lifecycle

        private void Awake()
        {
            _startButton.onClick.AddListener(StartButtonCliced);
            _exitButtonStartScreen.onClick.AddListener(ExitButtonCliced);
        }

        #endregion


        #region Private Methods

        private void StartButtonCliced()
        {
            SceneLoader.Instance.LoadScene(1);
        }
        
        private void ExitButtonCliced()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }

        #endregion
    }
