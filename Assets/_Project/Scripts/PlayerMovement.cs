using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void FixedUpdate() 
    {
        _speed += 0.045f * Time.deltaTime;
    }
}
