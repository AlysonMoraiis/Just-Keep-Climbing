using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallPurchaseScreen : MonoBehaviour
{
    [SerializeField] private SkinData _skinData;
    [SerializeField] private ScaleWindow _scaleWindow;
    [SerializeField] private PurchaseSkinScreen _purchaseSkinScreen;
    [SerializeField] private SkinSelect _skinSelect;

    private void Start()
    {
        _skinData.HasPurchased = PlayerPrefs.GetInt(_skinData.SkinName) != 0;
    }

    public void HandleSkinButton()
    {
        Debug.Log("equipar skins" + _skinData.HasPurchased);
        if (_skinData.HasPurchased)
        {
            PlayerPrefs.SetInt("skinIndex", _skinData.SkinIndex);
            _skinSelect.SetPlayerSelected(_skinData.SkinIndex);
            return;
        }
        _purchaseSkinScreen.UpdateEdgeInfo(_skinData);
        _scaleWindow.OpenWindow();
    }
}
