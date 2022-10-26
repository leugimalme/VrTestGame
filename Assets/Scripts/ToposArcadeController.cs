using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToposArcadeController : MonoBehaviour
{
   [SerializeField]bool Canbegin = false;
    public DestroyObject destroyer;
    [SerializeField] private GameObject ToposPrefab;
    [SerializeField] private GameObject[] Spawns;
    private int NumeroAleatorio;
    [SerializeField] private int RangoArray;
    bool IsALreadyDestroyed = false;
    [Header("Tiempo del juego y reglas")]
    [SerializeField] private float Tiempo = 60.0f;
    [SerializeField] float Ronda1SpawnRate = 2.0f;
    [SerializeField] float Ronda2SpawnRate = 1.0f;
     float Ronda1SpawnRatex = 2.0f;
     float Ronda2SpawnRatex = 1.0f;
    [SerializeField] float tiempoDeVida = 2;
    float tiempoDeVidaRestante;
    private bool CanBeDestroy = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Canbegin == true)
        {
            Tiempo -= Time.deltaTime;

            if (Tiempo > 40 && Tiempo > 0)
            {
                tiempoDeVidaRestante = tiempoDeVida;

                if (Time.time > Ronda1SpawnRate && Time.time > Ronda1SpawnRatex)
                {
                    Ronda1SpawnRatex = Time.time + Ronda1SpawnRate;
                    NumeroAleatorio = Random.Range(0, RangoArray);
                    Instantiate(ToposPrefab, Spawns[NumeroAleatorio].transform.position, Quaternion.identity);
                    tiempoDeVidaRestante -= Time.deltaTime;
                    if (Time.time > tiempoDeVidaRestante)
                    {
                        destroyer.Destroy();
                    }
                }
            }
            if (Tiempo < 40 && Tiempo > 0 && Time.time > Ronda2SpawnRatex)
            {
                Ronda2SpawnRatex = Time.time + Ronda2SpawnRate;
                NumeroAleatorio = Random.Range(0, RangoArray);
                Instantiate(ToposPrefab, Spawns[NumeroAleatorio].transform.position, Quaternion.identity);
                tiempoDeVidaRestante -= Time.deltaTime;
                if (Time.time > tiempoDeVidaRestante)
                {
                    destroyer.Destroy();
                }
            }

            if (Tiempo < 0)
            {
                TemporizadorEnded();
            }
        }
        
    }

    private void TemporizadorEnded()
    {

    }

    public void AddPoints(int Puntos)
    {

    }

    public void IsDestroyed(bool IsAlive)
    {
        CanBeDestroy = IsAlive;
    }

}
