using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallPurchaseScreen : MonoBehaviour
{
    [SerializeField] private SkinData _skinData;
    [SerializeField] private GameData _gameData;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private RuntimeAnimatorController _skinAnimator;
    [SerializeField] private ScaleWindow _scaleWindow;
    [SerializeField] private PurchaseSkinScreen _purchaseSkinScreen;
    [SerializeField] private GameObject _available;
    [SerializeField] private GameObject _purchased;
    [SerializeField] private Button _skinButton;

    [SerializeField] private int _skinIndex;
    [SerializeField] private int _skinPrice;

    private void OnEnable()
    {
        CheckIfHasPurchased();
    }

    private void CheckIfHasPurchased()
    {
        _skinButton.interactable = true;
        if (_skinData.SkinHasPurchased[_skinIndex] == true)
        {
            _available.SetActive(false);
            _purchased.SetActive(true);
        }
        else
        {
            _available.SetActive(true);
            _purchased.SetActive(false);
        }

        if (_skinData.SkinIndex == _skinIndex)
        {
            _skinButton.interactable = false;
        }
    }

    public void HandleSkinButton()
    {
        if (_skinData.SkinHasPurchased[_skinIndex])
        {
            _skinData.SkinIndex = _skinIndex;
            _playerData.PlayerAnimatorController = _skinData.ActiveSkin[_skinData.SkinIndex];
            CheckIfHasPurchased();
            return;
        }
        _purchaseSkinScreen.UpdateEdgeInfo(_skinPrice, _skinIndex);
        _scaleWindow.OpenWindow();
        CheckIfHasPurchased();
    }
}
