using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ControlsGameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;

    public TMP_Text Ponto_text;
    public TMP_Text Vida_text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lives < 0)
        {
            Debug.Log("Game Over!");
        }
    }
    public void UpdateHUD()
    {
        Ponto_text.text = "Score: " + score;
        Vida_text.text = "Lives: " + lives;
    }
    public void AddPoints()
    {
            score += 1;
            Ponto_text.text = score.ToString();
    }

    public void RemoveLife()
    {
        if (lives > 0)
        {
            lives--;
            Vida_text.text = lives.ToString();
            if (lives <= 0)
            {
                Debug.Log("Game Over!");
            }
        }
    }

    public void Heal()
    {
        int healAmount = 1;
        lives += healAmount;    
        if (lives > 5)
        {
            lives -= 1;
        } else
        {
            Vida_text.text = lives.ToString();
        }
    }


}
