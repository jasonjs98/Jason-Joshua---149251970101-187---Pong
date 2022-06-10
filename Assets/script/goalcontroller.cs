using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalcontroller : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public scoremanager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddRightScore(1);
            }
            else
            {
                manager.AddLeftScore(1);
            }
        }
    }
    // Start is called before the first frame update
    
}
