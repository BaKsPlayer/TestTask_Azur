using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BottomBarSlider : MonoBehaviour
{
    [SerializeField] private Image _icon;

    [SerializeField] private TextMeshProUGUI _title;

    [SerializeField] private float _slideSpeed = 2500f;

    private RectTransform _rectTransform;
    private RectTransform _target;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void SetTitle(string title)
    {
        _title.text = title;
    }

    public void SetIcon(Sprite icon)
    {
        _icon.sprite = icon;
    }

    public void SetTarget(RectTransform target)
    {
        _target = target;
    } 

    private void Update()
    {
        Vector3 targetPosition = new Vector3(_target.localPosition.x, _rectTransform.localPosition.y);
        _rectTransform.localPosition = Vector3.MoveTowards(_rectTransform.localPosition, targetPosition, _slideSpeed * Time.deltaTime);
    }
}
