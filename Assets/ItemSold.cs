using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemSold : MonoBehaviour
{
    public int maxToBuy;
    [SerializeField]
    string itemname;
    [SerializeField]
    TextMeshProUGUI getTexName;

    public int price;
    [SerializeField]
    TextMeshProUGUI getTextPrice;
    private void Awake()
    {
        getTexName.text = itemname;
        getTextPrice.text = price.ToString() + "$";
    }
    public virtual bool passLimits() { return false; }
    public  void BuyItem() {

        if (!passLimits())
        {
            if (CoinsManager.CanBuyItem(price))
            {
                ActiveItemToSold();
            }
        }
        else
        {
            getTextPrice.text = "MAX";
        }
    }
    public virtual void ActiveItemToSold()
    {

    }
}
