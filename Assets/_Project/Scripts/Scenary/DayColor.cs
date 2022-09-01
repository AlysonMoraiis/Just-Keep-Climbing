using UnityEngine;
using UnityEngine.UI;

public class DayColor : MonoBehaviour
{
    [SerializeField] private Image _image;
    private float _aColor;
    private float _n;

    void Update()
    {
        if (_aColor <= 0.01f)
        {
            _n = +0.01f;
        }
        else if (_aColor >= 0.85f)
        {
            _n = -0.01f;
        }
        _aColor += _n * Time.deltaTime;
        _image.color = new Color(_image.color.r, _image.color.g, _image.color.b, _aColor);
    }
}
