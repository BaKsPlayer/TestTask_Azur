using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    //private void Awake()
    //{
    //    Wallet.Instance.AddGold(PlayerPrefs.GetInt("Gold"));
    //    Wallet.Instance.AddCrystals(PlayerPrefs.GetInt("Crystals"));

    //    Debug.Log($"Crystals: {PlayerPrefs.GetInt("Crystals")} / Gold: {PlayerPrefs.GetInt("Gold")}");
    //}

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Gold", Wallet.Instance.Gold);
       PlayerPrefs.SetInt("Crystals", Wallet.Instance.Crystals);

    }
}
