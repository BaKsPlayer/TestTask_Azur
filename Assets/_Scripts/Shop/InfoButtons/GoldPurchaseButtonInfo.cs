using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPurchaseButtonInfo : MonoBehaviour
{
    [SerializeField] private int _priceInCrystals;
    public int PriceInCrystals => _priceInCrystals;

    [SerializeField] private int _valueInGold;
    public int ValueInGold => _valueInGold;
}
