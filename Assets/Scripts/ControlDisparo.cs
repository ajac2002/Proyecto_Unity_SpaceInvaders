using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparo : MonoBehaviour
{
    private Rigidbody2D myrigidbody2D;
    public float bulletSpeed = 10f;
    public GameManager2 myGameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myGameManager = FindObjectOfType<GameManager2>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.velocity = new Vector2(0, bulletSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("ItemGood"))
        //{
            //    Destroy(collision.gameObject);
        //}
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            myGameManager.AddScore();

        }
    }
}
