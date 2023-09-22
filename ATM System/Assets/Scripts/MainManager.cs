using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    private int _inputMoney;
    public int InputMoney
    {
        get { return _inputMoney; }
        set
        {
            _inputMoney = value;
            OnInputMoney?.Invoke(value);
        }
    }
    public event Action<int> OnInputMoney;

    private int _mypocket;
    public int Mypocket
    {
        get { return _mypocket; }
        set
        {
            _mypocket = value;
            OnMypocketChanged?.Invoke(value);
        }
    }
    public event Action<int> OnMypocketChanged;

    private int _balance;
    public int Balance
    {
        get { return _balance; }
        set
        {
            _balance = value;
            OnBalanceChanged?.Invoke(value);
        }
    }
    public event Action<int> OnBalanceChanged;
    // �̱���ȭ > �̺�Ʈ �����ؼ� ����! score > balance ��ȭ�� ���� ������ Text�� ������Ʈ�ǵ���
    // ������ SetActive�� �� �ٲ���ұ�

    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Mypocket = 100000;
        Balance = 50000;
        InputMoney = 0;
    }


}
