using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlecontrol : MonoBehaviour
{
    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rigid;
    private float pad;
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
    public void PaddleChange()
    {
        pad = 3f;
        transform.localScale = new Vector3(0.3f,pad,1); 
        StartCoroutine(DurationLength(5f));
    }
    public void PaddleSpeed()
    {
        speed = speed *2;
        transform.Translate(new Vector3(0,Time.deltaTime * speed,0));
        StartCoroutine(DurationSpeed(5f));
    }
 
    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("TEST: "+ movement);
        rigid.velocity = movement ;
    }
    IEnumerator DurationSpeed (float duration)
    {
        yield return new WaitForSeconds(duration);
        speed = speed / 2;  
    }
    IEnumerator DurationLength (float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.localScale = new Vector3(0.3f,pad/2,1);
    }
}
