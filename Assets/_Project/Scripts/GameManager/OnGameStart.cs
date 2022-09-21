using UnityEngine;
using System.Collections;

public class OnGameStart : MonoBehaviour
{
    [SerializeField] private GameData _gameData;
    [SerializeField] private float _defaultSpeed;
    [SerializeField] private SpriteRenderer _playerSpriteRenderer;
    [SerializeField] private Material _flashMaterial;
    private Material _defaultMaterial;

    void Awake()
    {
        _defaultMaterial = _playerSpriteRenderer.material;
        if (_gameData.Revived)
        {
            RestoreGameStats();
            StartCoroutine(Invulnerable());
        }
        else
        {
            ResetGameStats();
        }
        Time.timeScale = 1;
    }

    private void RestoreGameStats()
    {
        _gameData.InGameCoin = _gameData.LastCoin;
        _gameData.Score = _gameData.LastScore;
        _gameData.PlayerSpeed = _gameData.LastPlayerSpeed;
    }

    private void ResetGameStats()
    {
        _gameData.InGameCoin = 0;
        _gameData.Score = 0;
        _gameData.PlayerSpeed = _defaultSpeed;
    }

    private IEnumerator Invulnerable()
    {
        _gameData.CanDamage = false;
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _flashMaterial;
        yield return new WaitForSeconds(0.2f);
        _playerSpriteRenderer.material = _defaultMaterial;
        _gameData.CanDamage = true;
    }
}
