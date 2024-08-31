using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 20;
    public int forcaPulo = 7;
    public bool onFloor;
    public bool onSpecialFloor;
    
    private Rigidbody rb; 
    private AudioSource source;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        TryGetComponent(out rb);
        TryGetComponent(out source);
    }


void OnCollisionEnter(Collision collision)
{
   if(!onFloor && collision.gameObject.tag == "Floor")
        {
           onFloor = true;   
        }

   else if(!onFloor && collision.gameObject.tag == "SpecialFloor")
        {
           onSpecialFloor = true;   
        }


}




    // Update is called once per frame
    void Update()
    {
        //movimentação do jogador
        Debug.Log("UPDATE");
        float h = Input.GetAxis("Horizontal"); // -1 esquerda, 0 nada, 1 direita
        float v = Input.GetAxis("Vertical"); // -1 pra trás, 0 nada, 1 pra frente

        Vector3 direcao = new Vector3(h, 0, v );
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);
        
        
        //pulo
        if(Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            onFloor = false;
        }
       






        //resetar por circunstâmcia
        if(transform.position.y <= - 15)
        {
            //jogador caiu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

         else if(Input.GetKeyDown(KeyCode.R))
        {
            //jogador caiu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        else if(onSpecialFloor == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
       
    
    }
}