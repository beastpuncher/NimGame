using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_titleText = null;
    [SerializeField] List<GameObject> rowButtons = new List<GameObject>();
    [SerializeField] List<GameObject> optionButtons = new List<GameObject>();

    public enum eDifficulty
    {
        EASY,
        MEDIUM,
        HARD
    }


}
