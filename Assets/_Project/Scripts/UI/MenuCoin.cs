using UnityEngine;

public class MenuCoin : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private TMPro.TMP_Text _text;


    void Start()
    {
        int tCoin = (int)_gameData.Coins;
        _text.text = tCoin.ToString();
    }
}
