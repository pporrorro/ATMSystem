using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    [SerializeField] Text _inputMoney;
    private MainManager _manager;
    
    // private int inputMoney;

    public void OnDepositClick()
    {
        string txt = _inputMoney.text.Replace(",","");
        if (int.TryParse(txt, out int inputMoney)) inputMoney = int.Parse(txt);
        else return;
        _manager.InputMoney += inputMoney;
    }



}
