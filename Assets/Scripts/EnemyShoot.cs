using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public GameObject misil;
    public Transform misilPos;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(misil, misilPos.position, Quaternion.identity);
    }

}
