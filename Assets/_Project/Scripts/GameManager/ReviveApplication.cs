using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveApplication : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private ScaleWindow _watchAdScreen;
    [SerializeField] private ScaleWindow _gameOverScreen;

    private void OnEnable()
    {
        PlayerCollisions.OnDeath += OpenWatchAdScreen;
    }

    private void OnDisable()
    {
        PlayerCollisions.OnDeath -= OpenWatchAdScreen;
    }

    private void OpenWatchAdScreen()
    {
        Time.timeScale = 0;
        if (_gameData.Revived)
        {
            _gameOverScreen.OpenWindow();
            return;
        }
        _watchAdScreen.OpenWindow();
    }

    //botão fica inativo, score recebe score antigo, moeda recebe moeda antiga, speed volta para a antiga, fica invuneravel.
}
