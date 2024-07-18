using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController Character;
    public float speed = 15;
    
    private Vector3 MoveDirection;


    Animator anime;
 
    // Start is called before the first frame update
 
    void Start()
    {
        anime = GetComponent<Animator>();
        Character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Character.isGrounded){
            anime.SetBool("IsWalk",false);
            MoveDirection = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
            MoveDirection *= speed;
            
            if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
                anime.SetBool("IsWalk",true);
            }


            Character.Move(MoveDirection * Time.deltaTime);

        }
    }
}
