using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class Statistics : SingletonMonoBehaviour<Statistics>
{
    #region Variables
    
    public int Points;
    public int Iterator = 1;
    [SerializeField] public int HPCount = 4;

    #endregion
    

    #region Public Methods

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