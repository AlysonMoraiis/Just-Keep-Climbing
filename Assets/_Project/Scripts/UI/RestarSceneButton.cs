using UnityEngine.SceneManagement;
using UnityEngine;

public class RestarSceneButton : MonoBehaviour
{
    public void HandleRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
