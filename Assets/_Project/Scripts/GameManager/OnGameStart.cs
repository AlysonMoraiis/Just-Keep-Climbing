using UnityEngine;

public class OnGameStart : MonoBehaviour
{
    [SerializeField] private GameData _gameData;

    void Awake()
    {
        if(_gameData.Revived)
        {
            RestoreGameStats();
        }
        else
        {
            ResetGameStats();
        }
        Time.timeScale = 1;
    }

    private void RestoreGameStats()
    {
        _gameData.InGameCoin = _gameData.LastCoin;
        _gameData.Score = _gameData.LastScore;
    }

    private void ResetGameStats()
    {
        _gameData.InGameCoin = 0;
        _gameData.Score = 0;
    }
}
