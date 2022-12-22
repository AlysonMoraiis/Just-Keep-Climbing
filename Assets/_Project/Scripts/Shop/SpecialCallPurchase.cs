using UnityEngine;
using UnityEngine.SceneManagement;

public class SpecialCallPurchase : MonoBehaviour
{
    [SerializeField] private SkinData _skinData;
    [SerializeField] private SkinSelect _skinSelect;
    [SerializeField] private GameObject _buttonObject;
    [SerializeField] private GameObject _hasPurchasedButtonObject;

    private void Start()
    {
        _skinData.HasPurchased = PlayerPrefs.GetInt(_skinData.SkinName) != 0;
        if (_skinData.HasPurchased == true)
        {
            DisableButton();
        }
    }

    public void HandleSkinButton()
    {
        Debug.Log("equipar skins" + _skinData.HasPurchased);
        _skinData.HasPurchased = true;
        PlayerPrefs.SetInt(_skinData.SkinName, (_skinData.HasPurchased ? 1 : 0));
        _skinSelect.SetPlayerSelected(_skinData.SkinIndex);
        PlayerPrefs.SetInt("skinIndex", _skinData.SkinIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //DisableButton();
    }

    private void DisableButton()
    {
        _buttonObject.SetActive(false);
        _hasPurchasedButtonObject.SetActive(true);
    }
}
