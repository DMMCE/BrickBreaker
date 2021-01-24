using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayRemainBullets : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI GetText;
    
    MachineGun GetMachine;
    private void Awake()
    {
        GetMachine = GameObject.FindGameObjectWithTag("Machine").GetComponent<MachineGun>();
    }
    private void Update()
    {
        GetText.text = GetMachine.NumberofBullet.ToString();
    }
}
