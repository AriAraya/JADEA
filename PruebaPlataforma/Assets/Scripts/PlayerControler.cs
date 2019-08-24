using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    bool canJump;  

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        if (Input.GetKey("left") )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5000f*Time.deltaTime,0));

            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right"))
        {
           // diferencia = ;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(5000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5000f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = true;
        }
    }
    
}
