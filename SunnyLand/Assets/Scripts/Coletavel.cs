using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class Coletavel : MonoBehaviour
{
    private bool foiColetado = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Rodando!");
    }
    public ParticleSystem efeito;
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
            outroObjeto.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(efeito);
        }
    }
}
