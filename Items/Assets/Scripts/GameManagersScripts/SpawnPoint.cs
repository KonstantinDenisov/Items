using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : SingletonMonoBehaviour<SpawnPoint>
{
    #region Variables

    [SerializeField] private ItemInfo[] _itemsInfoArrey;
    [Range(0f, 1f)]
    [SerializeField] private float _itemSpawnChance;

    #endregion


    #region Public Methods

    public void SpawnItems()
    {
        if (_itemsInfoArrey == null || _itemsInfoArrey.Length == 0)
            return;

        float random = Random.Range(0f, 1f);
        if (random > _itemSpawnChance)
            return;

        int chanceSum = 0;

        foreach (ItemInfo pickUpInfo in _itemsInfoArrey)
        {
            chanceSum += pickUpInfo.SpawnChance;
        }

        int randomChance = Random.Range(0, chanceSum);
        int currentChance = 0;
        int currentIndex = 0;

        for (int i = 0; i < _itemsInfoArrey.Length; i++)
        {
            ItemInfo pickUpInfo = _itemsInfoArrey[i];
            currentChance += pickUpInfo.SpawnChance;

            if (currentChance >= randomChance)
            {
                currentIndex = i;
                break;
            }
        }

        ItemsBase pickUpPrefab = _itemsInfoArrey[currentIndex].ItemPrefab;
        Instantiate(pickUpPrefab, transform.position, Quaternion.identity);
    }

    #endregion
}
