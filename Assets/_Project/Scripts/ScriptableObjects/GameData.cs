using UnityEngine;

[CreateAssetMenu(fileName = "GameData")]
public class GameData : ScriptableObject
{
    [Header("Player")]
    public float Score;
    public float Highscore;
    public int MenuCoin;
    public int InGameCoin;
    public float PlayerSpeed;
    public bool CanDamage;

    [Header("Revive Conditions")]
    public float LastPlayerSpeed;
    public float LastScore;
    public int LastCoin;
    public bool Revived;

    [Header("Others")]
    public bool SoundStats;
}
