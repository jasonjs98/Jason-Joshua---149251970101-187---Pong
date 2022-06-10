using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("pong");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Jason Joshua - 149251970101-187");
    }
}
