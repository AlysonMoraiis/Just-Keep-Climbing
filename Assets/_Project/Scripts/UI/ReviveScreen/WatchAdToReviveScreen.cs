using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WatchAdToReviveScreen : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private Slider _slider;
    [SerializeField] private ScaleWindow _gameOverScreen;
    [SerializeField] private GameObject _watchAdScreen;
    [SerializeField] private AudioClip _audioClip;
    private bool _canCount;
    private float _timer;

    private void OnEnable()
    {
        _timer = 0;
        _canCount = true;
    }

    private void OnDisable()
    {
        _canCount = false;
    }

    private void Update()
    {
        if (_canCount)
        {
            _timer += 0.25f * Time.unscaledDeltaTime;
            _slider.value = _timer;
            if (_timer >= 1)
            {
                _gameOverScreen.OpenWindow();
                _watchAdScreen.SetActive(false);
            }
        }
    }

    public void HandleReviveButton()
    {
        SoundManager.Instance.PlaySound(_audioClip);
        _gameData.Revived = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
