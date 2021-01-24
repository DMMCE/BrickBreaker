using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class displayCoin : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI getText;
    private void Update()
    {
        getText.text = CoinsManager.CoinsInPocket.ToString();
    }
}
