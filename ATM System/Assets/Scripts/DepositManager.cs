using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DepositManager : MonoBehaviour
{
    [SerializeField] GameObject MainGroup;
    [SerializeField] GameObject DepositGroup;
    [SerializeField] Text _mypocket;
    [SerializeField] Text _balance;
    MainManager _manager;
    private void Awake()
    {
        _manager = MainManager.Instance;
    }

    public void SetDepositGroup()
    {
        MainGroup.SetActive(false);
        DepositGroup.SetActive(true);
    }
    public void SetMainGroup()
    {
        MainGroup.SetActive(true);
        DepositGroup.SetActive(false);
    }

    void Start()
    {
        _manager.OnMypocketChanged += UpdateMypocketText;
        _manager.OnBalanceChanged += UpdateBalanceText;
        _manager.OnInputMoney += DepositToBalance;
    }

    private void UpdateBalanceText(int balance)
    {
        _balance.text = balance.ToString("N0");
    }

    private void UpdateMypocketText(int mypocket)
    {
        _mypocket.text = mypocket.ToString("N0");
    }

    private void DepositToBalance(int inputmoney)
    {
        _manager.Mypocket -= inputmoney;
        if (_manager.Mypocket < 0)
        {
            _manager.Mypocket += inputmoney;
            return;
        }
        _manager.Balance += inputmoney;
        _manager.InputMoney = 0;
    }
}
