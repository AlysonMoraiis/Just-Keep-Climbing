using UnityEngine;

[CreateAssetMenu(fileName = "GameData")]
public class GameData : ScriptableObject
{
    [Header("Player")]
    public float Score;
    public float Highscore;
    public int Coins;
    public int InGameCoin;
    public float PlayerSpeed;
    public bool CanDamage;
    public int DeathsCount;

    [Header("Revive Conditions")]
    public float LastPlayerSpeed;
    public float LastScore;
    public int LastCoin;
    public bool Revived;

    [Header("Others")]
    public bool SoundStats;
    public bool HasPurchasedRemoveAds;
}
