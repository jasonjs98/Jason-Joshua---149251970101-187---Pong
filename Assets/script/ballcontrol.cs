using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    public void SpeedUp(float magnitude)
    {
        rigid.velocity *= magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
}
