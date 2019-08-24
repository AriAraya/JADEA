using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMov : MonoBehaviour
{
    public GameObject personaje;
    float posOriginal;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(((personaje.transform.position.x - posOriginal) + 21) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-1*(((personaje.transform.position.x - posOriginal) +21)) * Time.deltaTime, 0, 0);
        }
        posOriginal = personaje.transform.position.x;
    }

}
