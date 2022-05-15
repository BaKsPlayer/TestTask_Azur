using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public void PurchaseCrystals(CrystalsPurchaseButtonInfo buttonInfo)
    {
        Wallet.Instance.AddCrystals(buttonInfo.ValueInCrystals);
    }

    public void PurchaseGold(GoldPurchaseButtonInfo buttonInfo)
    {
        if (Wallet.Instance.Crystals >= buttonInfo.PriceInCrystals)
        {
            Wallet.Instance.SpendCrystals(buttonInfo.PriceInCrystals);
            Wallet.Instance.AddGold(buttonInfo.ValueInGold);
        }
    }
}
