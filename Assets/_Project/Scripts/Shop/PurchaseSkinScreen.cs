using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PurchaseSkinScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _priceText;
    [SerializeField] private GameData _gameData;
    [SerializeField] private SkinData _skinData;
    [SerializeField] private MenuManager _menuManager;
    [SerializeField] private ScaleWindow _scaleWindow;
    [SerializeField] private SkinSelect _skinSelect;
    [SerializeField] private AudioClip _effectSound;

    public event Action OnPurchase;

    public void UpdateEdgeInfo(SkinData skins)
    {
        _skinData = skins;
        _priceText.text = skins.SkinPrice.ToString();
    }

    public void HandlePurchaseButton()
    {
        if (_gameData.Coins > _skinData.SkinPrice)
        {
            _gameData.Coins -= _skinData.SkinPrice;
            _skinData.HasPurchased = true;
            _skinSelect.SetPlayerSelected(_skinData.SkinIndex);
            _menuManager.TextUpdate();
            _scaleWindow.CloseWindowCall();
            OnPurchase?.Invoke();
        }
        else
        {
            SoundManager.Instance.PlaySound(_effectSound);
        }
    }
}
