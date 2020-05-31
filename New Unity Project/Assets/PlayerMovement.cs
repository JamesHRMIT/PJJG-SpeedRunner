using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Created following the tutorial provided by Brackeys
//https://www.youtube.com/watch?v=dwcT-Dch0bA&t=1013s
//Youtube. 2020. 2D Movement In Unity. [online] Available at: <https://www.youtube.com/watch?v=dwcT-Dch0bA&t=1013s> [Accessed 1 May 2020].
public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        { jump = true; }
            
        
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }
  
}
