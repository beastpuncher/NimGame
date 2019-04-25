using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RowButton : MonoBehaviour
{
    public List<GameObject> rowPieces = new List<GameObject>();
    static int rowNum = 1;
    string m_rowName = null;
    bool m_enabled = false;
    public int index = 0;

    public bool isEnabled { get { return m_enabled; } set { m_enabled = value; } }

    void Start()
    {
        m_rowName = "Row " + rowNum;
        rowNum++;
    }
    public void OnClick()
    {
        transform.parent.parent.parent.GetComponent<UI>().checkWinCon();
        transform.parent.parent.parent.GetComponent<UI>().piecesTaken += 1;
        index = rowPieces.Count-1;
        m_enabled = true;
        if (ValidateMove())
        {
            GameObject obj = rowPieces[index];
            rowPieces.RemoveAt(index);
            Destroy(obj);
        }
    }

    public bool ValidateMove()
    {
        bool valid = false;
        if (rowPieces.Count > 0 && m_enabled)
        {
            valid = true;
        }
        return valid;
    }

    public void UpdateUI()
    {
        foreach(var go in rowPieces)
        {
            //go.Update();
        }
    }
}
