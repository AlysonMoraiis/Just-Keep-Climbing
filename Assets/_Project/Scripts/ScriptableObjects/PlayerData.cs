using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData")]
public class PlayerData : ScriptableObject
{
    public float PlayerSpeed;
    public bool CanDamage;
    public float LastPlayerSpeed;
    public bool Revived;
    public RuntimeAnimatorController PlayerAnimatorController;    
}
