using UnityEngine;

public class ResetReviveConditionsOnMenu : MonoBehaviour
{
    [SerializeField] private GameData _gameData;

    private void Awake()
    {
        _gameData.Revived = false;
    }
}
