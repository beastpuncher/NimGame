using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Player
{
    //[SerializeField] UI m_ui = null;
    [SerializeField] List<RowButton> m_rowButtons = null;

    public bool RandomlyPickStuff()
    {
        RowButton rb = m_rowButtons[(int)(Random.value % m_rowButtons.Count)];
        for(int i = 0; i < Random.value % rb.index; i++)
        {
            rb.OnClick();
        }
        return false;
    }
}
