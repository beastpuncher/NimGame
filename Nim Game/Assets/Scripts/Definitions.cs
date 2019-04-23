using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Definitions : MonoBehaviour
{
    public enum eGameMode
    {
        PLAYER_VS_PLAYER,
        PLAYER_VS_COMPUTER
    }
    public enum eDiffcultyenum
    {
        EASY,
        MEDIUM,
        HARD
    }
    public enum eWinCondition
    {
        LAST_WIN,
        LAST_LOSE
    }
}
