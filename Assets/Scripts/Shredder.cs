using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            Debug.Log("Hit " + collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }

}
