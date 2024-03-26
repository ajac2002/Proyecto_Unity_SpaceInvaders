using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text puntos;

    public void AddScore()
    {
        score++;
        puntos.text = "Torretas = " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(score == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
