using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private TMP_Text _text;


    void Start()
    {
        int tHighscore = (int)_gameData.Highscore;
        _text.text = tHighscore.ToString();
    }
}
