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
        MainManager.Instance.OnMypocketChanged += UpdateMypocketText;
        MainManager.Instance.OnBalanceChanged += UpdateBalanceText;
    }

    private void UpdateBalanceText(int balance)
    {
        _balance.text = balance.ToString("N0");
    }

    private void UpdateMypocketText(int mypocket)
    {
        _mypocket.text = mypocket.ToString("N0");
    }

}
