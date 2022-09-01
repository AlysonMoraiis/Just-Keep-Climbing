using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickDestroy : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bear"))
        {
            _animator.SetTrigger("Destroy");
            Destroy(gameObject, 1);
        }
    }
}
