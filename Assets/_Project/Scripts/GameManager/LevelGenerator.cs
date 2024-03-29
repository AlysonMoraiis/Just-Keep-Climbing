using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform _levelPartStart;
    [SerializeField] private List<Transform> _levelPartList_1;
    [SerializeField] private GameObject _playerGameObject;
    //[SerializeField] private GameData _gameData;

    private Vector3 _playerPosition;
    private Vector3 _lastEndPosition;
    private float _playerDistanceToSpawn = 20F;
    private Transform _chosenLevelPart;


    private void Awake()
    {
        _lastEndPosition = _levelPartStart.Find("EndPosition").position;
        int startingSpawnLevelParts = 3;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }


    private void Update()
    {
        if (Vector3.Distance(_playerPosition, _lastEndPosition) < _playerDistanceToSpawn)
        {
            SpawnLevelPart();
        }
        _playerPosition = _playerGameObject.transform.position;
        // if (_playerCollisions._playerIsAlive)
        // {
        //     _playerPosition = _playerGameObject.transform.position;
        // }
    }


    private void SpawnLevelPart()
    {
        _chosenLevelPart = _levelPartList_1[Random.Range(0, _levelPartList_1.Count)];

        Transform lastLevelPartTransform = SpawnLevelPart(_chosenLevelPart, _lastEndPosition);
        _lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }


    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
