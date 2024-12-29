using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 5;
    public float time = 2f;
    public float timer = 0f;
    public float speed = 20f;    
    int i = 1;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        
            Move();
            
        
        
    }
    public virtual void Move()
    {
        if (timer >= time)
        {
            if (i == 1)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                i = 0;
            }
            else if (i == 0)
            {

                transform.Translate(Vector3.left * speed * Time.deltaTime);
                i = 1;
            }


            timer = 0;
        }




    }
        
}
