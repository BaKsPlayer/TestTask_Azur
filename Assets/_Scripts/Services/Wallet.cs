using UnityEngine;
using UnityEngine.Events;

public class Wallet
{
    public int Gold { get; private set; }
    public event UnityAction OnGoldValueChanged;

    public int Crystals { get; private set; }
    public event UnityAction OnCrystalsValueChanged;

    private static Wallet _instance;
    public static Wallet Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Wallet();

                _instance.Initialize();
            }

            return _instance;
        }
    }

    private void Initialize()
    {
       AddGold(PlayerPrefs.GetInt("Gold"));
       AddCrystals(PlayerPrefs.GetInt("Crystals"));
    }

    public void AddGold(int amount)
    {
        Gold += amount;
        OnGoldValueChanged?.Invoke();
    }

    public void SpendGold(int amount)
    {
        Gold -= amount;
        OnGoldValueChanged?.Invoke();
    }

    public void AddCrystals(int amount)
    {
        Crystals += amount;
        OnCrystalsValueChanged?.Invoke();
    }

    public void SpendCrystals(int amount)
    {
        Crystals -= amount;
        OnCrystalsValueChanged?.Invoke();
    }
}
