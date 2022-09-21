using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScreen : MonoBehaviour
{
    [SerializeField] private Button _skin1Button;
    [SerializeField] private RuntimeAnimatorController _skin1Animator;
    [SerializeField] private Button _skin2Button;
    [SerializeField] private RuntimeAnimatorController _skin2Animator;
    [SerializeField] private Button _skin3Button;
    [SerializeField] private RuntimeAnimatorController _skin3Animator;
    [SerializeField] private Button _skin4Button;
    [SerializeField] private RuntimeAnimatorController _skin4Animator;
    [SerializeField] private Button _skin5Button;
    [SerializeField] private RuntimeAnimatorController _skin5Animator;
    [SerializeField] private Button _skin6Button;
    [SerializeField] private RuntimeAnimatorController _skin6Animator;
    [SerializeField] private Button _skin7Button;
    [SerializeField] private RuntimeAnimatorController _skin7Animator;
    [SerializeField] private PlayerData _playerData;

    public void HandleButton1()
    {
        _playerData.PlayerAnimatorController = _skin1Animator;
    }

    public void HandleButton2()
    {
        _playerData.PlayerAnimatorController = _skin2Animator;
    }

    public void HandleButton3()
    {
        _playerData.PlayerAnimatorController = _skin3Animator;
    }

    public void HandleButton4()
    {
        _playerData.PlayerAnimatorController = _skin4Animator;
    }

    public void HandleButton5()
    {
        _playerData.PlayerAnimatorController = _skin5Animator;
    }

    public void HandleButton6()
    {
        _playerData.PlayerAnimatorController = _skin6Animator;
    }

    public void HandleButton7()
    {
        _playerData.PlayerAnimatorController = _skin7Animator;
    }

}
