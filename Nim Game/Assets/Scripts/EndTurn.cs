using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    private string btnText;
    public void FinishTurn()
    {
       // Game.m_activePlayer = (Game.m_activePlayer == Game.m_player1) ? Game.m_player2 : Game.m_player1;
        Game.isOneTurn = (Game.isOneTurn) ? false : true;
        Debug.Log(Game.isOneTurn);
    }
}
