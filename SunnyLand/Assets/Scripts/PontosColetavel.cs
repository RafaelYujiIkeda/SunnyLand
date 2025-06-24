using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class PontosColetavel : MonoBehaviour
{
    public int pontos = 0;
    private bool foiColetado = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou! com " + pontos + " pontos");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public TMP_Text texto_pontos;
    public ParticleSystem efeito3;
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (foiColetado) return;
        if (outro.CompareTag("Player"))
        {
            foiColetado = true; // Marca como coletado

            // restante do código
        }
        if (outro.CompareTag("Player"))
        {
            pontos = pontos + 1;
            texto_pontos.text = pontos.ToString();
            Instantiate(efeito3, transform.position, Quaternion.identity);
            Destroy(efeito3);
        }
    }
}

    