using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class Inimigo : MonoBehaviour
{
    public int vida = 5;
    private bool foiColetadoR = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public TMP_Text texto_vidas;
    public ParticleSystem efeito1;
    private int vidaR = 5;
    private void OnTriggerEnter2D(Collider2D outraVidaR)
    {
        if (foiColetadoR) return;
        if (outraVidaR.CompareTag("Player"))
        {
            foiColetadoR = true; // Marca como coletado

            // restante do código
        }
        if (outraVidaR.CompareTag("Player"))
        {
            vidaR = vida - 1;
            texto_vidas.text = vidaR.ToString();
            Instantiate(efeito1, transform.position, Quaternion.identity);
            Destroy(efeito1);
        }
    }
}