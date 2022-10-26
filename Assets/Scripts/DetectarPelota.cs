using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarPelota : MonoBehaviour
{
    public AddPoints Puntos;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Pelota"))
        {
            Puntos.Puntos();
            Debug.Log("Colision");
        }
    }
}
