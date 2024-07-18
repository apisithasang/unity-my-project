using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private CharacterController chr;
   public float speed = 1;
   private Vector3 MD;

   Animator anima;
 
    // Start is called before the first frame update
 
    void Start()
    {
        anima = GetComponent<Animator>();
        chr = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if(chr.isGrounded){
        anima.SetBool("IsWalk",false);
         MD = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
        MD *= speed;
        
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
            anima.SetBool("IsWalk",true);
        }
        // Rotation Player Function
        Rotate();
        chr.Move(MD * Time.deltaTime);
       }
    }


    void Rotate(){

        // Rotation Player
        if(Input.GetAxis("Horizontal") <0){

            this.transform.rotation = Quaternion.Euler(0.0f,-90f,0.0f);
        }

        if(Input.GetAxis("Horizontal") >0){
            this.transform.rotation = Quaternion.Euler(0.0f,90f,0.0f);
        }

        if(Input.GetAxis("Vertical") >0){
            this.transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
        }

        if(Input.GetAxis("Vertical") <0){
            this.transform.rotation = Quaternion.Euler(0.0f,-180f,0.0f);
        }

    }
}
