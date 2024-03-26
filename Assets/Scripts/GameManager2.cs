using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public int score;
    public Text puntos;

    public void AddScore()
    {
        score--;
        puntos.text = "Enemigos Restantes = " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (score == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
}
