using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerSkin : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private SkinData _skinData;

    void Start()
    {
        _playerAnimator.runtimeAnimatorController =  _skinData.ActiveSkin[_skinData.SkinIndex];
    }
}
