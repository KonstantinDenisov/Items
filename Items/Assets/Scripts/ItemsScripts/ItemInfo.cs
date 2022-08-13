using System;
using UnityEngine;

[Serializable]
public class ItemInfo 
{
    #region Variables
    
    [HideInInspector]
    public string name;
    public ItemsBase ItemPrefab;
    public int SpawnChance;

    #endregion
    
    #region Public Methods

    public void UpdateName()
    {
        name = ItemPrefab == null ? string.Empty : ItemPrefab.name;
    }

    #endregion
}
