using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private float _scoreMultiplier;

    private void Start()
    {
        _gameData.Score = 0;
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
}
