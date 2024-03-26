using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullar1 : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] public Transform[] puntosMovimiento;
    [SerializeField] private float distanciaMinimia;
    private int siguientePaso = 0;
    private SpriteRenderer spriteRenderer;
    public ControlJugador ControlJugador;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[siguientePaso].position, velocidadMovimiento * Time.deltaTime);

        if(Vector2.Distance(transform.position, puntosMovimiento[siguientePaso].position) < distanciaMinimia)
        {
            siguientePaso += 1;
            if (siguientePaso >= puntosMovimiento.Length)
            {
                //EnemyDeath();
                siguientePaso = 0;
            }
            Girar();
        }
    }

    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("DeathZone"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void Girar()
    {
        if (transform.position.x < puntosMovimiento[siguientePaso].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    private void EnemyDeath()
    {
        Destroy(gameObject);
    }



}
