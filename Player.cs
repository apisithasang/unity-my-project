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
        // Player Character Check Floor
       if(chr.isGrounded){
        // Player animation Idle When IsWalk is false
        anima.SetBool("IsWalk",false);
         MD = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
        MD *= speed;
        
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
                // Player animation Walk When IsWalk is true
            anima.SetBool("IsWalk",true);
        }
        // Rotation Player Function
        Rotate();
        // Player Character Get Move Function Add Parameter MD Calurator Time.deltTime For Smooth Movement.
        chr.Move(MD * Time.deltaTime);
       }
    }

    void Rotate(){
        
        // Left Direction
        if(Input.GetAxis("Horizontal") < 0){
            this.transform.rotation = Quaternion.Euler(0.0f,-90f,0.0f);
        }
        // Right Direction
        if(Input.GetAxis("Horizontal") >0 ){
            this.transform.rotation = Quaternion.Euler(0.0f,90f,0.0f);
        }
        // Back Direction
        if(Input.GetAxis("Vertical") < 0){
            this.transform.rotation = Quaternion.Euler(0.0f,180f,0.0f);
        }
        // Front Direction
        if(Input.GetAxis("Vertical") > 0){
            this.transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
        }


    }


   
}
