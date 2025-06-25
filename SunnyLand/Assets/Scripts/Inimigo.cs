using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class Inimigo : MonoBehaviour
{
    private bool foiColetado = false;
    public ParticleSystem efeito;
    public ControlsGameManager ControlsGameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D outroObjeto)
    {
        if (foiColetado) return;
        if (outroObjeto.CompareTag("Player"))
        {
            foiColetado = true; // Marca como coletado

            if (outroObjeto.CompareTag("Player"))
            {
                ControlsGameManager.RemoveLife();
            }
        }
        Instantiate(efeito, transform.position, Quaternion.identity);

    }
}