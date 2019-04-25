using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    private string btnText;
    public bool FinishTurn()
    {
        Game.m_activePlayer = (Game.m_activePlayer == Game.m_player1) ? Game.m_player2 : Game.m_player1;
        return true;
    }
}
