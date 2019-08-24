using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarigueya : MonoBehaviour
{
    float velocidad = 10000;
    float timer;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.identity;
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            timer = 0;
            velocidad += 50;
        }
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 4000f));
        
    }
}
