using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DepositManager : MonoBehaviour
{
    public void LoadDepositScene()
    {
        SceneManager.LoadScene("DepositScene");
    }    
}
