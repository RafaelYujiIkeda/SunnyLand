using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class PontosColetavel : MonoBehaviour
{
    public ParticleSystem efeito;
    private bool foiColetado = false;
    public ControlsGameManager ControlsGameManager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou! com " + ControlsGameManager.score + " pontos");
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

            // restante do código
        }
        if (outroObjeto.CompareTag("Player"))
        {
            ControlsGameManager.AddPoints();
        }
        Instantiate(efeito, transform.position, Quaternion.identity);

    }
}

    