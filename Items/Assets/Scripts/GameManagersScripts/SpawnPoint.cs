using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : SingletonMonoBehaviour<SpawnPoint>
{
    #region Variables

    [SerializeField] private ItemInfo[] _itemsInfoArrey;
    [Range(0f, 1f)]
    [SerializeField] private float _itemSpawnChance;
    //private bool _wasSpawn;
    [SerializeField] private float _startTimeSpawn;
    [SerializeField] private float _multiplyTimeSpawn;
    private float _currentTimeSpawn;
    [SerializeField] private float _firstCoordinateRange;
    [SerializeField] private float _secondCoordinateRange;

    #endregion


    #region Unity Lifecycle

    private void Start()
    {
        _currentTimeSpawn = _startTimeSpawn;
        InvokeRepeating("SpawnItems", _startTimeSpawn, _currentTimeSpawn);
        
        // _wasSpawn = false; 
    }

    /*
        private void Update()
        {
            if (_wasSpawn)
            {
                return;
            }
    
            SpawnItems();
            _wasSpawn = true;
        }
    */

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

        foreach (ItemInfo itemInfo in _itemsInfoArrey)
        {
            chanceSum += itemInfo.SpawnChance;
        }

        int randomChance = Random.Range(0, chanceSum);
        int currentChance = 0;
        int currentIndex = 0;

        for (int i = 0; i < _itemsInfoArrey.Length; i++)
        {
            ItemInfo itemInfo = _itemsInfoArrey[i];
            currentChance += itemInfo.SpawnChance;

            if (currentChance >= randomChance)
            {
                currentIndex = i;
                break;
            }
        }

        ItemsBase itemPrefab = _itemsInfoArrey[currentIndex].ItemPrefab;
        Instantiate(itemPrefab, new Vector3(Random.Range(_firstCoordinateRange, _secondCoordinateRange),transform.position.y,transform.position.z), Quaternion.identity);

        // _wasSpawn = false;
        _currentTimeSpawn *= _multiplyTimeSpawn;
    }

    #endregion


    #region PrivateMethods
/*
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(_currentTimeSpawn);
    }
*/
    #endregion
}