using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RowButton : MonoBehaviour
{
    [SerializeField]List<GameObject> rowPieces = new List<GameObject>();
    static int rowNum = 1;
    string m_rowName = null;
    bool m_enabled = false;
    int index;
    void Start()
    {
        m_rowName = "Row " + rowNum;
        rowNum++;
        index = rowPieces.Count;
    }
    public void OnClick()
    {
        m_enabled = true;
        rowPieces.RemoveAt(index);
        index--;
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
