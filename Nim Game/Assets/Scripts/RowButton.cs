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
    void Start()
    {
        m_rowName = "Row " + rowNum;
        rowNum++;
    }
    public void OnClick()
    {
        index = rowPieces.Count-1;
        m_enabled = true;
        if (ValidateMove())
        {
            rowPieces.RemoveAt(index);
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
