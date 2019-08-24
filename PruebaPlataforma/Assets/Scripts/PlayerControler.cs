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
        if (Input.GetKey("down"))
        {
            gameObject.GetComponent<Animator>().SetBool("agachandose", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("agachandose", false);
            if (Input.GetKey("left"))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-7000f * Time.deltaTime, 0));
                gameObject.GetComponent<Animator>().SetBool("moving", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetKey("right"))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(7000f * Time.deltaTime, 0));
                gameObject.GetComponent<Animator>().SetBool("moving", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (!Input.GetKey("right") && !Input.GetKey("left"))
            {
                gameObject.GetComponent<Animator>().SetBool("moving", false);
            }

            if (Input.GetKeyDown("up") && canJump)
            {
                gameObject.GetComponent<Animator>().SetBool("jumping", true);
                canJump = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5000f));
            }
            if (!canJump)
            {
                gameObject.GetComponent<Animator>().SetBool("falling", true);
                
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            gameObject.GetComponent<Animator>().SetBool("falling", false);
            canJump = true;
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
        }
    }
}
