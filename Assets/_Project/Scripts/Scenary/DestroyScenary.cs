using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScenary : MonoBehaviour
{
    private Vector3 _playerPosition;
    private Vector3 _levelPosition;
    private GameObject _playerGameObject;
    //[SerializeField] private float _maxDistance;

    private void Awake()
    {
        // _levelPosition = gameObject.transform.position;
        // _playerGameObject = GameObject.Find("Player");
    }

    void Update()
    {
        // if (Vector3.Distance(_playerPosition, _levelPosition) > _maxDistance)
        // {
        //     Destroy(gameObject);
        //     Debug.Log("MaxDistance");
        // }
        // _playerPosition = _playerGameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Abyss"))
        {
            Destroy(gameObject);
        }
    }
}
