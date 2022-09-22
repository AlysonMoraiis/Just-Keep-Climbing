using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Material _deathMaterial;
    [SerializeField] private AudioClip _deathClip;

    public static event Action OnDeath;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && _gameData.CanDamage)
        {
            _spriteRenderer.material = _deathMaterial;
            OnDeath?.Invoke();
            SoundManager.Instance.PlaySound(_deathClip);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
