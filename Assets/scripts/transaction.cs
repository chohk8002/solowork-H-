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
            ShowPopup("�Ա��� �Ϸ�Ǿ����ϴ�.");
        }
        else
        {
            ShowPopup("�Աݱݾ��� Ȯ�����ּ���.");
        }
    }

    public void Withdraw(int withdrawAmount)
    {
        if (withdrawAmount > 0 && withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            UpdateBalanceText();
            ShowPopup("����� �Ϸ�Ǿ����ϴ�.");
        }
        else
        {
            ShowPopup("��� �ݾ��� Ȯ�����ּ���.");
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

