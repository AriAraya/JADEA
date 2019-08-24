using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarVidas : MonoBehaviour
{
    public Text texto;
    int vidas = 5;
    public GameObject jugador;
    float posOriginalX;
    float posOriginalY;
    public GameObject zarigueya;
    float posOZX;
    float posOZY;

    // Start is called before the first frame update
    void Start()
    {
        actualizarVidas();
        posOriginalX = gameObject.transform.position.x;
        posOriginalY = gameObject.transform.position.y;
        posOZX =zarigueya.transform.position.x;
        posOZY =zarigueya.transform.position.y;
    }


    private void actualizarVidas()
    {
        texto.text = "X" + vidas;
    }
    private void regresarOrigen()
    {
        jugador.transform.Translate(posOriginalX,posOriginalY,0);
    }

    private void regresarZarigueya()
    {
        zarigueya.GetComponent<Transform>().position = new Vector3(posOZX,posOZY,0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "frog")
        {
            vidas -= 1;
            
            actualizarVidas();
            regresarOrigen();
            regresarZarigueya();
        }
    }
}
