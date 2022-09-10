using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private GameObject _reviveButton;

    private void OnEnable()
    {
        if (_gameData.Revived)
        {
            _gameData.Revived = false;
            _reviveButton.SetActive(false);
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HandleMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
