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
    [SerializeField] TMP_Dropdown dDifficulty = null;
    [SerializeField] TMP_Dropdown dGameMode = null;
    [SerializeField] TMP_Dropdown dWinCondition = null;
    [SerializeField] TextMeshProUGUI m_p1Name = null;
    [SerializeField] TextMeshProUGUI m_p2Name = null;
    [SerializeField] TextMeshProUGUI m_activeName = null;
    
    public Definitions.eDiffcultyenum difficulty;
    public static Definitions.eGameMode gameMode;
    public Definitions.eWinCondition winCondition;
    public static bool isOneTurn = true;
    public static Player m_activePlayer = null;
    public static Player m_player1 = new Player();
    public static Player m_player2 = new Player();

    void Start()
    {
        m_activePlayer = m_player1;
        Main_Menu.SetActive(true);
        Main_Game.SetActive(false);
    }

    public void StartGame()
    {
        Main_Menu.SetActive(false);
        Main_Game.SetActive(true);
        difficulty = (Definitions.eDiffcultyenum)dDifficulty.value;
        gameMode = (Definitions.eGameMode)dGameMode.value;
        winCondition = (Definitions.eWinCondition)dWinCondition.value;
        
        m_player1.name = m_p1Name.text.ToString();
        m_player2.name = m_p2Name.text.ToString();
        Debug.Log(m_player1.name);
    }

    void Update()
    {
        if(isOneTurn) m_activeName.text = m_player1.name + "'s Turn";
        if(!isOneTurn) m_activeName.text = m_player2.name + "'s Turn";


    }

}
