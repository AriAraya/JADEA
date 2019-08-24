using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.scoreValue++;
        Destroy(gameObject);
        System.Console.WriteLine(ScoreScript.scoreValue);
    }
}
