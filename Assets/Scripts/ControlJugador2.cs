using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] private float velocidadNave;

    private Rigidbody2D rig;
    public GameObject Bala;
    public GameManager2 myGameManager;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        myGameManager = FindObjectOfType<GameManager2>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bala, transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        movimientoNave();
    }

    private void movimientoNave()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        rig.velocity = new Vector2(movX, movY) * velocidadNave;
     
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            PlayerDeath();
        }
        else if (collision.CompareTag("Asteroide"))
        {
            Destroy(collision.gameObject);
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        SceneManager.LoadScene("MenuInicial");
    }

}
