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


    public void HandleSkinButton()
    {
        if (_skinData.HasPurchased)
        {
            _skinSelect.SetPlayerSelected(_skinData.SkinIndex);
            return;
        }
        _purchaseSkinScreen.UpdateEdgeInfo(_skinData);
        _scaleWindow.OpenWindow();
    }
}
