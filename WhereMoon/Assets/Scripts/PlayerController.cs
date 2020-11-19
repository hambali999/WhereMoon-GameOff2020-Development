using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 5f;

    public GameObject gameOverText, restartButton, blood;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gameOverText.SetActive(false);
        restartButton.SetActive(false); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal"); //A & D, Left & Right Keys
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y); //keep y the same, dont change when moving left and right
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Spikes"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            Instantiate(blood, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
    