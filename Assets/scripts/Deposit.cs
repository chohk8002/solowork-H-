using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Deposit : MonoBehaviour
{
    public InputField amountInput;
    public TransactionController transactionController;
    public Text balanceText;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(deposit);
        UpdateBalanceText();
    }

    void deposit()
    {
        transactionController.deposit(int.Parse(amountInput.text));
    }

    void UpdateBalanceText()
    {
        //balanceText.text = "Balance: " + transactionController.GetBalance().ToString("C");
    }

    public void Deposit10000()
    {
        transactionController.deposit(10000);
        UpdateBalanceText();
    }

    public void Deposit30000()
    {
        transactionController.deposit(30000);
        UpdateBalanceText();
    }

    public void Deposit50000()
    {
        transactionController.deposit(50000);
        UpdateBalanceText();
    }

    public void DepositCustom()
    {
        int amount = int.Parse(amountInput.text);
        transactionController.deposit(amount);
        UpdateBalanceText();
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
