using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome = "Raposa";
    public int vidas = 5;
    public float velocidade = 2.5f;
    public bool isDead = false;
    private Rigidbody2D rb;
    public float novaGravidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
        Debug.Log($"Nome:\n{nome}");
        Debug.Log($"Vidas:\n{vidas}");
        Debug.Log($"Velocidade:\n{velocidade}");
        Debug.Log($"Você está morto:\n{isDead}");
        if ( isDead == false )
        {
            Debug.Log("Você se chama " + nome + ", têm " + vidas + " vidas, sua velocidade é de " + velocidade + " e você está vivo! ");
        } else
        {
            Debug.Log("Você se chama " + nome + ", têm " + vidas + " vidas e sua velocidade é de " + velocidade + " e você está morto!");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
