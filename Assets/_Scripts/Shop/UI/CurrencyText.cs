using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private enum CurrencyType { Gold, Crystals};

    [SerializeField] private CurrencyType _currencyType;


    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        switch (_currencyType)
        {
           case CurrencyType.Gold:
                Wallet.Instance.OnGoldValueChanged += GoldValueChanged;
                GoldValueChanged();
                break;

            case CurrencyType.Crystals:
                Wallet.Instance.OnCrystalsValueChanged += CrystalsValueChanged;
                CrystalsValueChanged();
                break;

            default:
                throw new NotImplementedException();
        }
    }

    private void OnDisable()
    {
        Wallet.Instance.OnGoldValueChanged -= GoldValueChanged;
        Wallet.Instance.OnCrystalsValueChanged -= CrystalsValueChanged;
    }

    private void GoldValueChanged()
    {
        _text.text = Wallet.Instance.Gold.ToString();
    }

    private void CrystalsValueChanged()
    {
        _text.text = Wallet.Instance.Crystals.ToString();
    }
}
