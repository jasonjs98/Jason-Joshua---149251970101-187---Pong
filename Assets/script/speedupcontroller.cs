using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedupcontroller : MonoBehaviour
{
    public powerupmanager manager;
    public Collider2D ball;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<ballcontrol>().SpeedUp(magnitude);
            manager.Removepowerup(gameObject);
        }
    }
    // Start is called before the first frame update
    
}
