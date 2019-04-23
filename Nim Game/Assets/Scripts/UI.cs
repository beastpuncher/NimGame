using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_titleText = null;
    [SerializeField] List<RowButton> rowButtons = new List<RowButton>();
    [SerializeField] List<GameObject> optionButtons = new List<GameObject>();

    private void Start()
    {
        foreach (var button in rowButtons)
        {
            foreach (var piece in button.rowPieces)
            {
                piece.SetActive(true);
            }
        }
    }

    private void Update()
    {
        foreach(var button in rowButtons)
        {
            foreach(var piece in button.rowPieces)
            {
                piece.SetActive(true);
            }
        }
    }
}
