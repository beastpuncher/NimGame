using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject Main_Menu = null;
    [SerializeField] GameObject Main_Game = null;
    [SerializeField] GameObject End_Prompt = null;
    [SerializeField] GameObject End_Prompt_2 = null;
    [SerializeField] TMP_Dropdown dif = null;
    [SerializeField] TMP_Dropdown mode = null;
    [SerializeField] TMP_Dropdown win = null;
    [SerializeField] TextMeshProUGUI m_p1Name = null;
    [SerializeField] TextMeshProUGUI m_p2Name = null;
    public Definitions.eDiffcultyenum difficulty;
    public Definitions.eGameMode gameMode;
    public Definitions.eWinCondition winCon;
    Player m_player1 = new Player();
    Player m_player2;

    void Start()
    {
        Main_Menu.SetActive(true);
        Main_Game.SetActive(false);
    }

    public void StartGame()
    {
        Main_Menu.SetActive(false);
        Main_Game.SetActive(true);
        difficulty = (Definitions.eDiffcultyenum)dif.value;
        gameMode = (Definitions.eGameMode)mode.value;
        winCon = (Definitions.eWinCondition)win.value;
        if (gameMode == Definitions.eGameMode.PLAYER_VS_PLAYER)
        {
            m_player2 = new Player();
        }
        else
        {
            m_player2 = new AI();
        }
        m_player1.name = m_p1Name.text.ToString();
        m_player2.name = m_p2Name.text.ToString();
        Debug.Log(m_player1.name);
    }

    void Update()
    {
       

    }

}
