using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalsPurchaseButtonInfo : MonoBehaviour
{
    [SerializeField] private float _priceInDollars;
    public float PriceInDollars => _priceInDollars;

    [SerializeField] private int _valueInCrystals;
    public int ValueInCrystals => _valueInCrystals;
}
