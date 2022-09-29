using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinManager : MonoBehaviour, ISaveable
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
        _gameData.Coins += _gameData.InGameCoin;
        CoinTextUpdate();
    }

    public object SaveState()
    {
        Debug.Log("Save coins: " + _gameData.Coins);
        return new SaveData()
        {
            coins = this._gameData.Coins
        };
    }

    public void LoadState(object state)
    {
       var saveData = (SaveData)state;
       _gameData.Coins = saveData.coins;
        Debug.Log("Load coins: " + _gameData.Coins);
    }

    [Serializable]
    private struct SaveData
    {
        public int coins;
    }
}
