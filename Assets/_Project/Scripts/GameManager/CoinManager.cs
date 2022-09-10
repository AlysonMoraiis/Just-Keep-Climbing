using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private TMPro.TMP_Text _text;

    private void Start()
    {
        CoinTextUpdate();
    }

    private void OnEnable()
    {
        Coin.OnCoinCollision += IncrementCoin;
        PlayerCollisions.OnDeath += UpdateTotalCoins;
    }

    private void OnDisable()
    {
        Coin.OnCoinCollision -= IncrementCoin;
        PlayerCollisions.OnDeath -= UpdateTotalCoins;
    }

    private void IncrementCoin()
    {
        _gameData.InGameCoin += 1;
        CoinTextUpdate();
    }

    private void CoinTextUpdate()
    {
        _text.text = _gameData.InGameCoin.ToString();
    }

    private void UpdateTotalCoins()
    {
        _gameData.LastCoin = _gameData.InGameCoin;
        _gameData.MenuCoin += _gameData.InGameCoin;
    }
}
