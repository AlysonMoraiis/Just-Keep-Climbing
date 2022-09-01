using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    [SerializeField] private GameObject _playerGameObject;
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
            }
            else if (touch.position.x > Screen.width / 2)
            {
                Debug.Log("Right click");
                _playerGameObject.transform.position = _rightPoint.position;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _playerGameObject.transform.position = _leftPoint.position;

        }
        else if (Input.GetKeyDown(KeyCode.X))
        {

            _playerGameObject.transform.position = _rightPoint.position;
        }
    }
}
