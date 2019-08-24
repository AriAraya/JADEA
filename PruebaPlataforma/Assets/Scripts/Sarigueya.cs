using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarigueya : MonoBehaviour
{
    float velocidad = 1000;
    float timer;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            timer = 0;
            velocidad += 10;
        }
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground"|| collision.transform.tag == "Zorro")
        {
            canJump = true;
            if (collision.transform.tag == "Zorro")
            {
                velocidad = 1000;
            }
        }
        else if (canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 4000f));
        }
    }
}
