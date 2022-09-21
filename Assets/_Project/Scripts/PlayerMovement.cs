using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameData _gameData;

    private void OnEnable()
    {   
        PlayerCollisions.OnDeath += SetLastPlayerSpeed;
    }

    private void OnDisable()
    {
        PlayerCollisions.OnDeath -= SetLastPlayerSpeed;
    }

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _gameData.PlayerSpeed);
    }

    private void FixedUpdate()
    {
        _gameData.PlayerSpeed += 0.045f * Time.deltaTime;
    }

    private void SetLastPlayerSpeed()
    {
        _gameData.LastPlayerSpeed = _gameData.PlayerSpeed;
    }
}
