using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController character;
    public float speed = 30;
    private Vector3 MoveDirection;
    
    // class animator
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(character.isGrounded){
            // animation walk set false
            anim.SetBool("IsWalk",false);
            MoveDirection = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
            MoveDirection *= speed;
            // animation controller
            if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
                anim.SetBool("IsWalk",true);
            
            }
            
            character.Move(MoveDirection*Time.deltaTime);
        }
    }
}
