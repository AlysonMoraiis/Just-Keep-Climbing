using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private Animator _animator;

    public static event Action OnCoinCollision;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.PlaySound(_audioClip);
            OnCoinCollision?.Invoke();
            _animator.SetTrigger("Destroy");
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
