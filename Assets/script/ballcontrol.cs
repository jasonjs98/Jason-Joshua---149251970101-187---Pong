using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }
}
