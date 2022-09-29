using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _menuCoinText;
    [SerializeField] private GameData _gameData;

    public void TextUpdate()
    {
        _menuCoinText.text = _gameData.Coins.ToString();
    }
}
