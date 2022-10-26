using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public AddPoints Puntos;
    bool destruido = false;

    public void Destroy()
    {
        if(destruido == false)
        {
            Destroy(gameObject);
        }       
    }

    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Martillo"))
        {
            Puntos.Puntos();
            Destroy(gameObject);
            destruido = true;
        }

        if (collision.CompareTag("Bullet"))
        {
            Debug.Log("hola");
            Puntos.Puntos();
            Destroy(gameObject);
            destruido = true;
        }
    }
}
