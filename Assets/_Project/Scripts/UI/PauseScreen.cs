using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _pauseButton;

    [Header("Others")]
    [SerializeField] private GameObject _menuScreen;

    private void Start()
    {
        _pauseButton.onClick.AddListener(HandlePauseButton);
    }

    public void HandleRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HandlePauseButton()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            _menuScreen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            _menuScreen.SetActive(false);
        }
    }
}
