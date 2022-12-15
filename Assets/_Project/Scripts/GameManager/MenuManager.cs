using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _menuCoinText;
    [SerializeField] private TMP_Text _menuHighscoreText;
    [SerializeField] private GameData _gameData;

    void Start()
    {
        _gameData.Coins = PlayerPrefs.GetInt("coins");
        _gameData.Highscore = PlayerPrefs.GetFloat("highscore");
        TextUpdate();
    }

    public void TextUpdate()
    {
        int tHighscore = (int)_gameData.Highscore;
        _menuCoinText.text = _gameData.Coins.ToString();
        _menuHighscoreText.text = tHighscore.ToString();
    }
}
