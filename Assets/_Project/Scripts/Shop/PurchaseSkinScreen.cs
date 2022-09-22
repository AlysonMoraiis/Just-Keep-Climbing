using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PurchaseSkinScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _priceText;
    [SerializeField] private GameData _gameData;
    [SerializeField] private SkinData _skinData;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private ScaleWindow _scaleWindow;

    private int _skinPrice;
    private int _skinIndex;

    public void UpdateEdgeInfo(int skinPrice, int skinIndex)
    {
        _skinPrice = skinPrice;
        _skinIndex = skinIndex;
        _priceText.text = _skinPrice.ToString();
    }

    public void HandlePurchaseButton()
    {
        if (_gameData.MenuCoin > _skinPrice)
        {
            _skinData.SkinIndex = _skinIndex;
            _gameData.MenuCoin -= _skinPrice;
            _skinData.SkinHasPurchased[_skinIndex] = true;
            _playerData.PlayerAnimatorController = _skinData.ActiveSkin[_skinData.SkinIndex];
            _scaleWindow.CloseWindowCall();
        }
    }
}
