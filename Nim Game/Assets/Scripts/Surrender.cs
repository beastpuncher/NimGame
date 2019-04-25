using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Surrender : MonoBehaviour
{
    [SerializeField] GameObject m_first_end = null;
    [SerializeField] GameObject m_second_end = null;
    [SerializeField] TextMeshProUGUI m_winnerText = null;

    public void clickSurrender()
    {
        if(m_first_end.activeSelf == false)
        {
            m_first_end.SetActive(true);
            m_winnerText.text = (Game.isOneTurn) ? Game.m_player2.name : Game.m_player1.name;
            m_winnerText.text += " Wins!";
        }
    }
    public void FirstNo()
    {
        if(m_second_end.activeSelf == false)
        {
            m_first_end.SetActive(false);
            m_second_end.SetActive(true);
        }
    }
    public void FirstYes()
    {
        if(m_first_end.activeSelf == true)
        {
            m_first_end.SetActive(false);
        }
        SceneManager.LoadScene("NimGame");
    }

    public void SecondYes()
    {
        SceneManager.LoadScene("NimGame");
        //exit application
    }
    public void SecondNo()
    {
        SceneManager.LoadScene("NimGame");
        //reload scene and start in begining
    }
}
