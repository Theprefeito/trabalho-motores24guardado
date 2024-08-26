using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Moeda : MonoBehaviour
{

    public int velocidadeGiro = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(valor:1);
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(UnityEngine.Vector3.up * velocidadeGiro * Time.deltaTime, relativeTo:Space.World);

    }
}
