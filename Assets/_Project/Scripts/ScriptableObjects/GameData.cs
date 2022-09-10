using UnityEngine;

[CreateAssetMenu(fileName = "GameData")]
public class GameData : ScriptableObject
{
    public bool SoundStats;
    public float Score;
    public float Highscore;
    public int MenuCoin;
    public int InGameCoin;

    [Header("Revive Conditions")]
    public bool Revived;
    public float LastScore;
    public int LastCoin;
}
