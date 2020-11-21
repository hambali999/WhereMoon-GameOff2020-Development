using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeScript : MonoBehaviour
{
    public float rotationSpeed;   //this is to make it access publicly from Unity Engine to make changes to the rotation speed!


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, 0, rotationSpeed));
    }

    //private void OnTriggerEnter2D(Collider2D collision)
 //   {
       // Destroy(collision.gameObject);
   // }
}
