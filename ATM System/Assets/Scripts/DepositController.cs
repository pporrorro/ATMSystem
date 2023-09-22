using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    [SerializeField] Text _inputMoney;
    
    private int inputMoney;

    private void Start()
    {
        MainManager.Instance.OnInputMoney += DepositToBalance;
    }
    public void DepositToBalance(int inputmoney)
    {
        MainManager.Instance.Balance += inputmoney;
        MainManager.Instance.Mypocket -= inputmoney;
    }



}
