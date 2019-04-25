using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RowButtonMaster : MonoBehaviour
{
    [SerializeField] UI m_ui = null;
    [SerializeField] List<GameObject> m_buttons = new List<GameObject>();
    public bool listCreated = false;

    void Start()
    {
      
    }
    
    void Update()
    {
        if (listCreated)
        {
            m_buttons = m_ui.buttons;
            foreach (GameObject obj in m_buttons)
            {
                if (obj.GetComponent<RowButton>().isEnabled)
                {
                    foreach (GameObject go in m_buttons)
                    {
                        if (go.GetComponent<RowButton>().isEnabled == false)
                        {
                            go.GetComponent<Button>().interactable = false;
                        }
                    }
                    break;
                }
            }
        }
    }

    public void ResetButtons()
    {
        foreach (GameObject obj in m_buttons)
        {
            obj.GetComponent<RowButton>().isEnabled = false;
            obj.GetComponent<Button>().interactable = true;
        }            
    }
}
