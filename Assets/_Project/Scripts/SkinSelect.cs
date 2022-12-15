using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SkinSelect : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private RuntimeAnimatorController[] playerController;
    [SerializeField] private Sprite[] playerRenderer;
    public int _index;
    public event Action OnEquip;

    private void Start()
    {
        _index = PlayerPrefs.GetInt("skinIndex");
        SetPlayerSelected(_index);
    }

    public void SetPlayerSelected(int index)
    {
        _index = index;
        spriteRenderer.sprite = playerRenderer[index];
        animator.runtimeAnimatorController = playerController[index];
        OnEquip?.Invoke();
    }
}
