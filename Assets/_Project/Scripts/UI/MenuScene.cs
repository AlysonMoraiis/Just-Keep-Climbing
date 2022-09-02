using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    [SerializeField] private AudioClip _effectSound;

    public void HandlePlayButton()
    {
        SceneManager.LoadScene("Game");
        SoundManager.Instance.PlaySound(_effectSound);
    }
}
