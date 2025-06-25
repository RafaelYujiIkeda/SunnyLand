using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class VidaColetavel : MonoBehaviour
{
    public ParticleSystem efeito;
    private bool foiColetado = false;
    public ControlsGameManager ControlsGameManager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou! com " + ControlsGameManager.lives + " vidas");
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
                ControlsGameManager.Heal();
            }
        }
        Instantiate(efeito, transform.position, Quaternion.identity);

    }
}