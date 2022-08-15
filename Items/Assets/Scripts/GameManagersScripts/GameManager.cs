using System;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{

    #region Events

    public event Action OnGameOver;
    public event Action OnGameWinn; 

    #endregion


    #region Public Methods

    public void LoseLife()
    {
        Statistics.Instance.NextImage();
        CheckGameOver();
    }

    public void PerformWin()
    {
        OnGameWinn?.Invoke();
    }

    #endregion


    #region Private Methods

    private void CheckGameOver()
    {
        if (Statistics.Instance.HPCount == 0)
        {
            OnGameOver?.Invoke();
        }
    }

    #endregion
}