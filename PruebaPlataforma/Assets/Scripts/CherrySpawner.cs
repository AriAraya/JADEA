using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherrySpawner : MonoBehaviour
{
    float timer;
    bool direction = true;
    public GameObject cherryPrefab;
    public GameObject personaje;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")){
            direction = false;
        }
        if (Input.GetKey("right"))
        {
            direction = true;
        }
        float x;
        timer += Time.deltaTime;
        if (direction){
            x = Random.Range(personaje.transform.position.x + 15, personaje.transform.position.x + 30);
            if (timer >= 2f)
            {
                timer = 0;
                float y = Random.Range(personaje.transform.position.y + 2, personaje.transform.position.y + 9);
                Vector3 position = new Vector3(x, y, 0);
                Quaternion rotation = new Quaternion();
                Instantiate(cherryPrefab, position, rotation);
            }
        }
        if (!direction)
        {
            x = Random.Range(personaje.transform.position.x - 15, personaje.transform.position.x - 30);
            if (timer >= 2f)
            {
                timer = 0;
                float y = Random.Range(personaje.transform.position.y + 2, personaje.transform.position.y + 9);
                Vector3 position = new Vector3(x, y, 0);
                Quaternion rotation = new Quaternion();
                Instantiate(cherryPrefab, position, rotation);
            }
        }
    }
}
