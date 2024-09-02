using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset;
    public int suavidade = 5;

    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offset = alvo.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posfinal = alvo.position - offset;
        transform.position = Vector3.Lerp(transform.position,posfinal,suavidade * Time.deltaTime);

    }
}
