using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public TextureOffsetController tof;
    public TextureOffsetController Tof;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //GameOver event when player collides with the saw
        if(collision.gameObject.tag == "Saw")
        {
            this.gameObject.SetActive(false);
            Debug.Log("Game Over");
            Time.timeScale = 0f;
            tof.speed = 0f;
            Tof.speed = 0f;
        }
    }

    //jump the player
    private void Jump() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = new Vector2(0, 15f);
        }
    
    }

    private void Update()
    {
        Jump();
    }

}
