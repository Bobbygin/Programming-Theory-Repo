using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public static MainUI S;
    public GameObject UIManager;
    private void Awake()
    {
        S= UIManager.GetComponent<MainUI>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            S.UpdateScore();
            Destroy(this.gameObject);
        }
    }
}
