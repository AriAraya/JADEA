using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aguila : MonoBehaviour
{
    float posOriginalX;
    float posOriginalY;
    // Start is called before the first frame update
    void Start()
    {
        posOriginalX = gameObject.transform.position.x;
        posOriginalY = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = GameObject.Find("Personaje").transform.position;
        var pos2 = gameObject.transform.position;
        float prob = Random.Range(0.0f, 100.0f);
        if (Mathf.Abs(pos.x - pos2.x) <= 50 && Mathf.Abs(pos.y-pos2.y) <= 50 && prob >= 60f)
        {
            float step = 50f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pos, step);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Zorro")
        {
            gameObject.GetComponent<Transform>().position = new Vector3(posOriginalX, posOriginalY, 0);
        }
    }
}
