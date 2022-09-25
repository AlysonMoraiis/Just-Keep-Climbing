using UnityEngine;
using UnityEngine.UI;

public class TapToPlayButton : MonoBehaviour
{
    [SerializeField] private Button _tapToPlayButton;
    [SerializeField] private GameObject _buttonGameObject;

    private void OnEnable()
    {
        _tapToPlayButton.onClick.AddListener(HandleTapToPlayButton);
    }
    private void OnDisable()
    {
        _tapToPlayButton.onClick.RemoveListener(HandleTapToPlayButton);
    }
    void Start()
    {
        Time.timeScale = 0;
    }

    private void HandleTapToPlayButton()
    {
        Time.timeScale = 1;
        _buttonGameObject.SetActive(false);
    }
}
