using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    [SerializeField] private GameObject _playerGameObject;
    [SerializeField] private SpriteRenderer _playerSpriteRenderer;
    [SerializeField] private Transform _leftPoint;
    [SerializeField] private Transform _rightPoint;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2 && Time.timeScale == 1)
            {
                _playerGameObject.transform.position = _leftPoint.position;

                if (_playerSpriteRenderer.flipX != true)
                {
                    _playerSpriteRenderer.flipX = true;
                }
            }
            else if (touch.position.x > Screen.width / 2 && Time.timeScale == 1)
            {
                _playerGameObject.transform.position = _rightPoint.position;
                _playerSpriteRenderer.flipX = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z) && Time.timeScale == 1)
        {
            _playerGameObject.transform.position = _leftPoint.position;
            _playerSpriteRenderer.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.X) && Time.timeScale == 1)
        {
            _playerGameObject.transform.position = _rightPoint.position;
            _playerSpriteRenderer.flipX = false;
        }
    }
}
