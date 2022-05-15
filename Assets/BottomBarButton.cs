using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBarButton : MonoBehaviour
{
    [SerializeField] private string _name;
    public string Name => _name;

    [SerializeField] private Sprite _icon;
    public Sprite Icon => _icon;

    [SerializeField] private Vector2 _selectedSize;
    [SerializeField] private Vector2 _unselectedSize;

    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void Select()
    {
        _rectTransform.sizeDelta = _selectedSize;
    }

    public void Unselect()
    {
        _rectTransform.sizeDelta = _unselectedSize;
    }
}
