using UnityEngine;
using DG.Tweening;

public class ScaleText : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private Vector3 _scaleTO;
    [SerializeField] private float _scaleTime = 1f;

    void Start()
    {
        _rectTransform.DOScale(_scaleTO, _scaleTime).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetUpdate(true);
    }
}
