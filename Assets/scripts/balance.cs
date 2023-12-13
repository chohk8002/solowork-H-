using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class balance : MonoBehaviour
{
    public Name name;
    public Text balanceText;

    private int accountBalance = 50000;

    private void Awake()
    {
        
    }
    public void Start()
    {
        accountBalance = 50000;
    }


    void UpdateUI()
    {
        name.UpdateUI();
        balanceText.text = "ภÜพื: " + accountBalance.ToString();
    }
}
