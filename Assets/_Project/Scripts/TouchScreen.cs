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
            if (touch.position.x < Screen.width / 2)
            {
                Debug.Log("Left click");
                _playerGameObject.transform.position = _leftPoint.position;

                if (_playerSpriteRenderer.flipX != true)
                {
                    _playerSpriteRenderer.flipX = true;
                }
            }
            else if (touch.position.x > Screen.width / 2)
            {
                Debug.Log("Right click");
                _playerGameObject.transform.position = _rightPoint.position;
                _playerSpriteRenderer.flipX = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _playerGameObject.transform.position = _leftPoint.position;
            _playerSpriteRenderer.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            _playerGameObject.transform.position = _rightPoint.position;
            _playerSpriteRenderer.flipX = false;
        }
    }
}
