using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public RectTransform CreditPage;
    
    public void StartGame()
    {
        SceneManager.LoadScene("InGameScene");
    }

    public void EnterCredit()
    {
        CreditPage.anchoredPosition = Vector2.zero;
    }

    public void CloseCredit()
    {
        CreditPage.anchoredPosition = Vector2.down * 500;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
