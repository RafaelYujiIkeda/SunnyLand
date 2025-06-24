using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class VidaColetavel : MonoBehaviour
{
    public int vida = 5;
    private bool foiColetado = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("O jogo começou! com " + vida + " vidas");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public TMP_Text texto_vidas;
    public ParticleSystem efeito;
    private void OnTriggerEnter2D(Collider2D outraVida)
    {
        if (foiColetado) return;
        if (outraVida.CompareTag("Player"))
        {
            foiColetado = true; // Marca como coletado

            // restante do código
        }
        if (outraVida.CompareTag("Player"))
        {
            vida = vida + 1;
            texto_vidas.text = vida.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(efeito);
        }
    }
}