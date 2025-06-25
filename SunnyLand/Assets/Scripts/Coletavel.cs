using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class Coletavel : MonoBehaviour
{
    private bool foiColetado = false;
    public ParticleSystem efeito;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Rodando!");
    }

    private void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (foiColetado) return;
        if (outroObjeto.CompareTag("Player"))
        {
            foiColetado = true; // Marca como coletado

            if (outroObjeto.CompareTag("Player"))
            {
                playerMovement.runSpeed += 30;
                Instantiate(efeito, transform.position, Quaternion.identity);
            }
        }

    }
}
