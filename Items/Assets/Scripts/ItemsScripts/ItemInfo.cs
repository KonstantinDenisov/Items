using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Rigidbody2D))]
public class ItemInfo 
{
    #region Variables
    
    [HideInInspector]
    public string name;
    public ItemsBase ItemPrefab;
    public int SpawnChance;
    public Rigidbody2D RB;

    #endregion
    
    #region Public Methods

    public void UpdateName()
    {
        name = ItemPrefab == null ? string.Empty : ItemPrefab.name;
    }

    #endregion
}
