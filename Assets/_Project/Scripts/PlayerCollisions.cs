using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class PlayerCollisions : MonoBehaviour
{
    public static event Action OnDeath;
    [SerializeField] private GameData _gameData;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && _gameData.CanDamage)
        {
            OnDeath?.Invoke();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
