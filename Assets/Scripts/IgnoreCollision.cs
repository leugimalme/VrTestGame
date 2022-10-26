using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] Transform Jugador;

    private void OnCollisionEnter(UnityEngine.Collision Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(Jugador.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
