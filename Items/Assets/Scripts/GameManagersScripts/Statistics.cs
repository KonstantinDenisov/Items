using System;
using UnityEngine;

public class Statistics : SingletonMonoBehaviour<Statistics>
{
    #region Variables
    
    public int Points;
    public int Iterator = 1;
    [SerializeField] public int HPCount = 4;

    #endregion
    

    #region Public Methods

    public void ResetStatistics()
    {
        HPCount = 4;
        Points = 0;
    }

    public void NextImage()
    {
        Iterator++;
        HPCount--;
    }
    
    public void ChangeScore(int score)
    {
        Points += score;
        CheckScore();
    }

    private void CheckScore()
    {
        if (Points == 5)
        {
            GameManager.Instance.PerformWin();
        }
    }

    #endregion
}