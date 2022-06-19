using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlelength : MonoBehaviour
{
    public powerupmanager manager;
    public Collider2D ball;
    public Collider2D paddleLeft;
    public Collider2D paddleRight;
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleLeft.GetComponent<paddlecontrol>().PaddleChange();
            paddleRight.GetComponent<paddlecontrol>().PaddleChange();
            manager.Removepowerup(gameObject);
        }
    }
}
