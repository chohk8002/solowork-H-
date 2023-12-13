using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class withdraw : MonoBehaviour
{
    public InputField amountInput;
    public TransactionController transaction;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Withdraw);
    }

    void Withdraw()
    {
        transaction.Withdraw(int.Parse(amountInput.text));
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
