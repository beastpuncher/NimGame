using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Game game = null;
    [SerializeField] GameObject gamePiece = null;
    [SerializeField] GameObject rowBut = null;
    [SerializeField] List<GameObject> rowPlaceholder = null;
    [SerializeField] List<GameObject> rowButtonPlaceholder = null;
    [SerializeField] GameObject m_parent = null;
    [SerializeField] int m_spacing = 20;
    [SerializeField] TextMeshProUGUI m_winnerText = null;
    [SerializeField] Button m_endTurnButton = null;
    List<GameObject> rowButtons = new List<GameObject>();
    public bool win = false;

    public bool firstTurn = true;
    public int piecesTaken = 0;

    private void Update()
    {
        if(!firstTurn && piecesTaken == 0)
        {
            m_endTurnButton.interactable = false;
        }
        else
        {
            m_endTurnButton.interactable = true;
        }
    }

    public List<GameObject> buttons { get { return rowButtons; } }

    public void GameStarted()
    {
        switch (game.difficulty)
        {
            case Definitions.eDiffcultyenum.EASY:
                for (int i = 0; i < 2; i++)
                {
                    Vector3 rowposition = rowButtonPlaceholder[i].transform.position;
                    GameObject obj = Instantiate(rowBut, rowposition, Quaternion.identity, rowButtonPlaceholder[i].transform);
                    rowButtons.Add(obj);
                    rowButtons[i].GetComponent<RowButton>().rowPieces.Clear();
                    for (int j = 0; j < 3; j++)
                    {
                        Vector3 position = rowPlaceholder[i].transform.position + (Vector3.right * j * m_spacing);
                        GameObject piece = Instantiate(gamePiece, position, Quaternion.identity, rowPlaceholder[i].transform);
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(piece);
                    }
                }
                break;
            case Definitions.eDiffcultyenum.MEDIUM:
                for (int i = 0; i < 3; i++)
                {
                    Vector3 rowposition = rowButtonPlaceholder[i].transform.position;
                    GameObject obj = Instantiate(rowBut, rowposition, Quaternion.identity, rowButtonPlaceholder[i].transform);
                    rowButtons.Add(obj);
                    rowButtons[i].GetComponent<RowButton>().rowPieces.Clear();
                    int x = 0;
                    if (i == 0)
                    {
                        x = 2;
                    }
                    else if (i == 1)
                    {
                        x = 5;
                    }
                    else
                    {
                        x = 7;
                    }
                    for (int j = 0; j < x; j++)
                    {
                        Vector3 position = rowPlaceholder[i].transform.position + (Vector3.right * j * m_spacing);
                        GameObject piece = Instantiate(gamePiece, position, Quaternion.identity, rowPlaceholder[i].transform);
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(piece);
                    }
                }
                break;
            case Definitions.eDiffcultyenum.HARD:
                for (int i = 0; i < 4; i++)
                {
                    Vector3 rowposition = rowButtonPlaceholder[i].transform.position;
                    GameObject obj = Instantiate(rowBut, rowposition, Quaternion.identity, rowButtonPlaceholder[i].transform);
                    rowButtons.Add(obj);
                    rowButtons[i].GetComponent<RowButton>().rowPieces.Clear();
                    int x = 0;
                    if (i == 0)
                    {
                        x = 2;
                    }
                    else if (i == 1)
                    {
                        x = 3;
                    }
                    else if (i == 2)
                    {
                        x = 8;
                    }
                    else
                    {
                        x = 9;
                    }
                    for (int j = 0; j < x; j++)
                    {
                        Vector3 position = rowPlaceholder[i].transform.position + (Vector3.right * j * m_spacing);
                        GameObject piece = Instantiate(gamePiece, position, Quaternion.identity, rowPlaceholder[i].transform);
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(piece);
                    }
                }
                break;
        }
        GetComponent<RowButtonMaster>().listCreated = true;
    }

    public void checkWinCon()
    {
        
        if (Game.winCondition == Definitions.eWinCondition.LAST_WIN)
        {
            win = true;
            foreach(GameObject obj in rowButtons)
            {
                if (obj.GetComponent<RowButton>().rowPieces.Count != 0)
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                GetComponent<Surrender>().clickSurrender();
            }
        }
        else
        {
            foreach (GameObject obj in rowButtons)
            {
                if (obj.GetComponent<RowButton>().rowPieces.Count == 0)
                {
                    win = true;                   
                }
                else
                {
                    win = false;
                    break;
                }
            }
            if (win)
            {
                Game.isOneTurn = !Game.isOneTurn;
                GetComponent<Surrender>().clickSurrender();
            }
        }
    }
}
