using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    #region Variables
    [Header("Screens")]
    [SerializeField] private GameObject _gameWinScreen;
    [SerializeField] private GameObject _gameOverLabel;
    [SerializeField] private GameObject _pauseImage;
    [SerializeField] private GameObject _startScreen;

    [Header("Buttons")]
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _playAgainButton;
    [SerializeField] private Button _resumeToGameButton;
    [SerializeField] private Button _exitButtonStartScreen;
    [SerializeField] private Button _exitButtonGameOver;
    [SerializeField] private Button _exitButtonPause;
    [SerializeField] private Button _exitGameWinScreen;
    [SerializeField] private Button _restartGameButtonGameOver;
    #endregion
    


    #region Utity Lifecycle

    private void Awake()
    {
        _gameWinScreen.SetActive(false);
        _gameOverLabel.SetActive(false);
        _pauseImage.SetActive(false);
        
        _restartGameButtonGameOver.onClick.AddListener(RestartGameButtonCliced);
        _startButton.onClick.AddListener(StartButtonCliced);
        _playAgainButton.onClick.AddListener(RestartGameButtonCliced);
        _resumeToGameButton.onClick.AddListener(ResumeToGameButtonCliced);
        _exitButtonGameOver.onClick.AddListener(ExitButtonCliced);
        _exitButtonPause.onClick.AddListener(ExitButtonCliced);
        _exitGameWinScreen.onClick.AddListener(ExitButtonCliced);
        _exitButtonStartScreen.onClick.AddListener(ExitButtonCliced);
    }

    private void Start()
    {
        PauseManager.Instance.OnPaused += Paused;
        GameManager.Instance.OnGameOver += GameOver;
        GameManager.Instance.OnGameWinn += GameWin;
        
        PauseManager.Instance.StopTime();
    }

    private void OnDestroy()
    {
        PauseManager.Instance.OnPaused -= Paused;
        GameManager.Instance.OnGameOver -= GameOver;
        GameManager.Instance.OnGameWinn -= GameWin;
    }


    #region Private Methods

    private void StartButtonCliced()
    {
        PauseManager.Instance.StartTime();
        _startScreen.SetActive(false);
    }

    private void ExitButtonCliced()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void RestartGameButtonCliced()
    {
        
    }

    private void ResumeToGameButtonCliced()
    {
        
    }

    private void Paused(bool isPaused)
    {
        _pauseImage.SetActive(isPaused);
    }

    private void GameWin()
    {
        _gameWinScreen.SetActive(true);  
        PauseManager.Instance.StopTime();
        AudioPlayer.Instance.AddWinAudioClip();
    }


    private void GameOver()
    { 
        _gameOverLabel.SetActive(true);
        PauseManager.Instance.StopTime();
        AudioPlayer.Instance.AddGameOverAudioClip();
    }

    #endregion
    

    #endregion
    
        
}