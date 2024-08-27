using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Plataforma : MonoBehaviour
{

    public int velocidadeGiroP = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }


   



    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(UnityEngine.Vector3.forward * velocidadeGiroP * Time.deltaTime, relativeTo:Space.World);

    }
}
