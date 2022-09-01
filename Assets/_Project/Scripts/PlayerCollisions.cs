using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Die");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
