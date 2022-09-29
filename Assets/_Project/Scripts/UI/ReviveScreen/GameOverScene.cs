using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScene : MonoBehaviour
{
    [SerializeField] private TMP_Text _highscoreText;
    [SerializeField] private GameData _gameData;
    [SerializeField] private GameObject _reviveButton;
    [SerializeField] private GameObject _shareButton;

    private void OnEnable()
    {
        HighscoreUpdate();
        if (_gameData.Revived)
        {
            _gameData.Revived = false;
            _reviveButton.SetActive(false);
            _shareButton.SetActive(true);
        }
    }
    public void HandleReviveButton()
    {
        _gameData.Revived = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HandleRestartButton()
    {
        _gameData.Revived = false;
        SaveLoadSystem.Instance.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HandleMenuButton()
    {
        SaveLoadSystem.Instance.Save();
        SceneManager.LoadScene("Menu");
    }

    private void HighscoreUpdate()
    {
        int tHighscore = (int)_gameData.Highscore;
        _highscoreText.text = tHighscore.ToString();
    }
}
