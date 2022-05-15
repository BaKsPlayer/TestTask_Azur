using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomBar : MonoBehaviour
{
    [SerializeField] private BottomBarSlider _slider;

    [SerializeField] private BottomBarButton _startButton;

    private RectTransform _sliderRectTransform;

    private BottomBarButton _selectedButton;

    private void Awake()
    {
        _sliderRectTransform = _slider.GetComponent<RectTransform>();

        Select(_startButton);
    }

    public void Select(BottomBarButton button)
    {
        _selectedButton?.Unselect();
        _selectedButton = button;

        button.Select();

        _slider.SetIcon(button.Icon);
        _slider.SetTitle(button.Name);

        _slider.SetTarget(button.GetComponent<RectTransform>());
    }
}
