using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosPuntos : MonoBehaviour
{
    public AddPoints puntos;
    [SerializeField] private int Puntacion;
    private void OnTriggerEnter(Collider collision)
    {
        // Start is called before the first frame update
        if (collision.CompareTag("DestroyObject"))
        {
            puntos.Puntos2(Puntacion);
            Destroy(gameObject);    
        }
    }
}
