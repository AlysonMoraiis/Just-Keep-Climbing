using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class PlayerCollisions : MonoBehaviour
{
    public static event Action OnDeath;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            OnDeath?.Invoke();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
