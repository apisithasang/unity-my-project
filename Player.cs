using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController character;
    public float speed = 15;
    private Vector3 MD;

    
    Animator anima;

 
    void Start()
    {
        anima = GetComponent<Animator>();
        character = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if(character.isGrounded){
            anima.SetBool("IsWalk",false);
            MD = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
            MD *= speed;

            if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){

                anima.SetBool("IsWalk",true);

            }
            Rotate();
            character.Move(MD*Time.deltaTime);

        }

    }

    void Rotate(){
        
        if(Input.GetAxis("Horizontal") <0 ){
            this.transform.rotation = Quaternion.Euler(0.0f,-90f,0.0f);
        }
        if(Input.GetAxis("Horizontal") >0 ){
            this.transform.rotation = Quaternion.Euler(0.0f,90f,0.0f);
        }
        if(Input.GetAxis("Vertical") <0 ){
            this.transform.rotation = Quaternion.Euler(0.0f,180f,0.0f);
        }
        if(Input.GetAxis("Vertical") >0 ){
            this.transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
        }

    }


  

  


   
}
