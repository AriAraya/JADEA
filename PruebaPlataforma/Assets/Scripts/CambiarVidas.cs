using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarVidas : MonoBehaviour
{
    public Text texto;
    int vidas = 5;
    float posOriginalX;
    float posOriginalY;

    // Start is called before the first frame update
    void Start()
    {
        actualizarVidas();
        posOriginalX = gameObject.transform.position.x;
        posOriginalY = gameObject.transform.position.y;
    }


    private void actualizarVidas()
    {
        texto.text = "X" + vidas;
    }
    private void regresarOrigen()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(posOriginalX,posOriginalY,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "frog")
        {
            vidas -= 1;
            
            actualizarVidas();
            regresarOrigen();
        }
    }
}
