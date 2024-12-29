using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePlatform : MovingPlatform//Inheritance
{
    public float speed1 = 35f;
    public GameObject player;
    public Vector3 playerRespawn;
    public override void Move()//Polymorhphism
    {
        speed=speed1;
        base.Move();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            player.transform.Translate(playerRespawn);
        }
    }
}
