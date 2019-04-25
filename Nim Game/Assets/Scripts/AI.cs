﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Player
{
    [SerializeField] List<GameObject> m_rowButtons = null;
    [SerializeField] GameObject m_endTurnButton = null;

    private void Start()
    {
        m_rowButtons = GetComponent<UI>().buttons;
    }

    private void Update()
    {
        if(Game.isOneTurn == false && Game.gameMode == Definitions.eGameMode.PLAYER_VS_COMPUTER)
        {
           //Debug.Log("AI " + Game.m_activePlayer.name);
           RandomlyPickStuff();
        }
    }

    public bool RandomlyPickStuff()
    {
        GameObject obj = m_rowButtons[(int)(Random.Range(0, m_rowButtons.Count))];
        RowButton rb = obj.GetComponent<RowButton>();
        int rand = Random.Range(1, rb.rowPieces.Count);
        for (int i = 0; i < rand; i++)
        {
            rb.OnClick();
        }
        m_endTurnButton.GetComponent<EndTurn>().FinishTurn();
        GetComponent<RowButtonMaster>().ResetButtons();
        return false;
    }
}
