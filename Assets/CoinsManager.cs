using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
        
    }
    public static bool CanBuyItem(int price)
    {
        if(CoinsInPocket >= price)
        {
            PlayerPrefs.SetInt("CoinsInPocket" , CoinsInPocket - price);
            return true;
        }
        return false;
    }
   public static  void AddCoins(int value)
    {
        if (value >  5) return;
        PlayerPrefs.SetInt("CoinsInPocket" , CoinsInPocket + value);

    }

    static int getCoinsInPocket() { return PlayerPrefs.GetInt("CoinsInPocket"); }

    public static int CoinsInPocket { get => getCoinsInPocket(); }
}
