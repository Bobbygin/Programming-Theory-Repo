using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 pos;
   
    // Start is called before the first frame update
    void Start()
    {
        pos=transform.position;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos = transform.position;
        pos.x = player.transform.position.x-5.6f;
        pos.y = player.transform.position.y;
        transform.position = pos;
    }
}
