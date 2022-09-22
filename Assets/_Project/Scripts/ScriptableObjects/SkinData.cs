using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData")]
public class SkinData : ScriptableObject
{
    public List<bool> SkinHasPurchased;
    public List<RuntimeAnimatorController> ActiveSkin;
    public int SkinIndex;
    // public bool Skin_2_HasPurchased;
    // public bool Skin_3_HasPurchased;
    // public bool Skin_4_HasPurchased;
    // public bool Skin_5_HasPurchased;
    // public bool Skin_6_HasPurchased;
    // public bool Skin_7_HasPurchased;
}
