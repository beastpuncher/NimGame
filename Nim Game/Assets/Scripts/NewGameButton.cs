using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    private string Name = "New Game";

    public string text { get { return Name; } }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}
