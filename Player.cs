using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController character;
    public float speed = 30;
    private Vector3 MoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(character.isGrounded){
            MoveDirection = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
            MoveDirection *= speed;
            character.Move(MoveDirection*Time.deltaTime);
        }
    }
}
