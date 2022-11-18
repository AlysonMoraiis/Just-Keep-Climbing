using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private float _scoreMultiplier;

    void OnEnable()
    {
        PlayerCollisions.OnDeath += OnPlayerDeath;
    }

    private void Update()
    {
        _scoreMultiplier += 0.03f * Time.deltaTime;
        _gameData.Score += _scoreMultiplier * Time.deltaTime;
        ScoreTextUpdate();
    }

    void ScoreTextUpdate()
    {
        int tScore = (int)_gameData.Score;
        _scoreText.text = tScore.ToString();
    }

    private void OnPlayerDeath()
    {
        if (_gameData.Score > _gameData.Highscore)
        {
            _gameData.Highscore = _gameData.Score;
        }
        _gameData.LastScore = _gameData.Score;
    }
}
