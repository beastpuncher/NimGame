using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] Game game = null;
    [SerializeField] GameObject gamePiece = null;
    [SerializeField] GameObject rowBut = null;
    [SerializeField] List<GameObject> rowPlaceholder = null;
    [SerializeField] List<GameObject> rowButtonPlaceholder = null;
    List<GameObject> rowButtons = new List<GameObject>();
    List<GameObject> optionButtons = new List<GameObject>();

    private void Start()
    {
       
    }

    public void GameStarted()
    {
        switch (game.difficulty)
        {
            case Definitions.eDiffcultyenum.EASY:
                for (int i = 0; i < 2; i++)
                {
                    rowButtons.Add(rowBut);
                    for (int j = 0; j < 3; j++)
                    {
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(gamePiece);
                    }
                }
                break;
            case Definitions.eDiffcultyenum.MEDIUM:
                for (int i = 0; i < 3; i++)
                {
                    rowButtons.Add(rowBut);
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
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(gamePiece);
                    }
                }
                break;
            case Definitions.eDiffcultyenum.HARD:
                for (int i = 0; i < 4; i++)
                {
                    rowButtons.Add(rowBut);
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
                        rowButtons[i].GetComponent<RowButton>().rowPieces.Add(gamePiece);
                    }
                }
                break;
        }
        Debug.Log(rowButtons.Count);
        for(int i = 0; i<rowButtons.Count-1; i++)
        {
            Vector3 position = rowButtonPlaceholder[i].transform.position;
            Instantiate(rowButtons[i], position, Quaternion.identity);
        }
    }

    private void Update()
    {
        
    }
}
