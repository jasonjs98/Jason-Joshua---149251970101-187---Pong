using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontrol : MonoBehaviour
{
    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
       
       MoveObject(GetInput());
        
    }
    private Vector2 GetInput()
    {
         
        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        rigid.velocity = movement ;
    }
}
