using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePrefab : MonoBehaviour
{
    [SerializeField] private GameObject _collectables_1;
    [SerializeField] private GameObject _collectables_2;
    [SerializeField] private GameObject _collectables_3;

    private Vector3 _playerPosition;
    private Vector3 _levelPosition;
    private GameObject _playerGameObject;


    //[SerializeField] private float _maxDistance;

    private void Start()
    {
        RandomInstantiate();
    }

    private void Awake()
    {
        // _levelPosition = gameObject.transform.position;
        // _playerGameObject = GameObject.Find("Player");
    }

    private void Update()
    {
        // if (Vector3.Distance(_playerPosition, _levelPosition) > _maxDistance)
        // {
        //     Destroy(gameObject);
        //     Debug.Log("MaxDistance");
        // }
        // _playerPosition = _playerGameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Abyss"))
        {
            Destroy(gameObject);
        }
    }

    private void RandomInstantiate()
    {
        int randomCollectable = Random.Range(0, 10);
        if (randomCollectable >= 3)
        {
            int randomGroup = Random.Range(0, 30);
            if (randomGroup <= 9)
            {
                _collectables_1.SetActive(true);
                return;
            }
            else if (randomGroup >= 21)
            {
                _collectables_3.SetActive(true);
                return;
            }
                _collectables_2.SetActive(true);
        }
    }
}
