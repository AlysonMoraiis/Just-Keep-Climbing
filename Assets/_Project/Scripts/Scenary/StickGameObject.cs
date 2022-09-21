using System.Collections.Generic;
using UnityEngine;

public class StickGameObject : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private List<Sprite> _sprites;

    private int _spriteIndex;

    private void Start()
    {
        RandomSprite();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bear"))
        {
            _animator.enabled = true;
            _animator.SetTrigger("Destroy");
            Destroy(gameObject, 1);
        }
    }

    private void RandomSprite()
    {
        _spriteIndex = Random.Range(0, _sprites.Count);
        _spriteRenderer.sprite = _sprites[_spriteIndex];
    }
}
