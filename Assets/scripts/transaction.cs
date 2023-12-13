using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransactionController : MonoBehaviour
{
    public Text balanceText;
    public Text popupText;

    private int balance = 50000;

    // Start is called before the first frame update
    void Start()
    {
        UpdateBalanceText();
    }

    public void deposit(int depositAmount)
    {
        if (depositAmount > 0)
        {
            balance += depositAmount;
            UpdateBalanceText();
            ShowPopup("입금이 완료되었습니다.");
        }
        else
        {
            ShowPopup("입금금액을 확인해주세요.");
        }
    }

    public void Withdraw(int withdrawAmount)
    {
        if (withdrawAmount > 0 && withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            UpdateBalanceText();
            ShowPopup("출금이 완료되었습니다.");
        }
        else
        {
            ShowPopup("출금 금액을 확인해주세요.");
        }
    }

    void UpdateBalanceText()
    {
        balanceText.text = "balance: " + balance.ToString("C");
    }

    public void ShowPopup(string message)
    {
        popupText.text = message;
        popupText.gameObject.SetActive(true);

        Invoke("HidePopup", 2f);
    }

    void HidePopup()
    {
        popupText.gameObject.SetActive(false);
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainScene");
    }
}  

