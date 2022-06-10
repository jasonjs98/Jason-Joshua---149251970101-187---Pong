using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{
    public ballcontrol ball;
    public int rightscore;
    public int leftscore;
    public int maxscore;
    // Start is called before the first frame update
    
    public void AddRightScore(int increment)
    {
        rightscore += increment;
        ball.ResetBall();
        if (rightscore >= maxscore)
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increment)
    {
        leftscore += increment;
        ball.ResetBall();
        if(leftscore >= maxscore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("main menu");
    }
}
