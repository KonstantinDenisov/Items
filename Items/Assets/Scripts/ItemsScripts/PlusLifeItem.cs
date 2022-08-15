using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusLifeItem : ItemsBase
{

    #region Unity Lifecycle

    void Start()
    {
        IsGoodItem = true;
        Score = 1;
    }

    #endregion
        
    protected override void ApplyEffect(Collision2D col)
    {
        Statistics.Instance.HPCount++;
    }
}
