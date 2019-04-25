using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    private string btnText;
    [SerializeField] UI m_Ui = null;

    public void FinishTurn()
    {
       // Game.m_activePlayer = (Game.m_activePlayer == Game.m_player1) ? Game.m_player2 : Game.m_player1;
        Game.isOneTurn = (Game.isOneTurn) ? false : true;
        m_Ui.firstTurn = false;
        m_Ui.piecesTaken = 0;
        m_Ui.checkWinCon();
    }
}
