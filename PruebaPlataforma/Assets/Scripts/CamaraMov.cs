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
            gameObject.transform.Translate(((personaje.transform.position.x - posOriginal)+10) * Time.deltaTime, 0, 0);
        }
        posOriginal = personaje.transform.position.x;
    }

}
