using System;
using TMPro;
using UnityEngine;

public class StatisticsLabel : MonoBehaviour
{
    #region Variables
    
    [SerializeField] private TextMeshProUGUI _statisticsLabel;

    #endregion


    #region Unity Lifecycle

    private void Update()
    {
        SetStatisticsLabel();
    }

    #endregion


    #region Private Methods
    
    private void SetStatisticsLabel()
    {
        _statisticsLabel.text = $"Score - {Statistics.Instance.Points}";
    }
    
    #endregion
}