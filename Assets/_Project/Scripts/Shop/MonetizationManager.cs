using UnityEngine;

public class MonetizationManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private GameObject _removeAdsButton;

    private void Start()
    {
        _gameData.HasPurchasedRemoveAds = PlayerPrefs.GetInt("PURCHASED_REMOVE_ADS") != 0;
        if (_gameData.HasPurchasedRemoveAds == true)
        {
            HideRemoveAdsButton();
        }
    }

    public void OnPurchaseRemoveAds()
    {
        _gameData.HasPurchasedRemoveAds = true;
        PlayerPrefs.SetInt("PURCHASED_REMOVE_ADS", (_gameData.HasPurchasedRemoveAds ? 1 : 0));
        PlayerPrefs.Save();
        HideRemoveAdsButton();
    }

    private void HideRemoveAdsButton()
    {
        _removeAdsButton.SetActive(false);
    }
}
