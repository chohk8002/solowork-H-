using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text nameText;

    public string userName = "사용자이름";
    
    // Start is called before the first frame update
    public void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    { 
        nameText.text = "이름" + userName;
    }

    public void SetUserName(string newName)
    { 
        userName = newName;
        UpdateUI();
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
