using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private Animator _animator;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.PlaySound(_audioClip);
            _animator.SetTrigger("Destroy");
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
