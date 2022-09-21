using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerSkin : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private PlayerData _playerData;

    void Start()
    {
        _playerAnimator.runtimeAnimatorController = _playerData.PlayerAnimatorController;
    }
}
