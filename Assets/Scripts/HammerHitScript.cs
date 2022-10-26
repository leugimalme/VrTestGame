using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHitScript : MonoBehaviour
{

    public ToposArcadeController controller;
    public AddPoints Puntos;
    bool CanBe = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Martillo"))
        {
            CanBe = true;
            controller.IsDestroyed(CanBe);
            Puntos.Puntos();
            Destroy(gameObject);    
        }
    }
}
