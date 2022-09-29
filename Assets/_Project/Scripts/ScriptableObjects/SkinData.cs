using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData")]
public class SkinData : ScriptableObject
{
    public Sprite SkinImage;
    public int SkinPrice;
    public int SkinIndex;
    public bool HasPurchased;
}
