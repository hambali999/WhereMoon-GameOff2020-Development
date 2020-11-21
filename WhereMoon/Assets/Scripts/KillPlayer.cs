using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField]Transform spawnPoint;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
            collision.transform.position = spawnPoint.position;  //will transform the postition of the box2d collision area to back to the spawnPoint postition .

    }
}
 