using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Surrender : MonoBehaviour
{
    [SerializeField] GameObject m_first_end = null;
    [SerializeField] GameObject m_second_end = null;

    public void clickSurrender()
    {
        if(m_first_end.activeSelf == false)
        {
            m_first_end.SetActive(true);
        }
    }
    public void FirstYes()
    {
        if(m_second_end.activeSelf == false)
        {
            m_first_end.SetActive(false);
            m_second_end.SetActive(true);
        }
    }
    public void FirstNo()
    {
        if(m_first_end.activeSelf == true)
        {
            m_first_end.SetActive(false);
        }
    }

    public void SecondYes()
    {
        SceneManager.LoadScene("NimGame");
        //reload scene and start in begining
    }
    public void SecondNo()
    {
        if(m_second_end.activeSelf == true)
        {
            m_second_end.SetActive(false);
        }
    }
}
