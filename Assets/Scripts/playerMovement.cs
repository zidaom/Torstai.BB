using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private CharacterController;
   private float gravity = -9.81;

   private float moveSpeed = 8f;
   private float jumpHeight = 3f;

    void Start()
    {
        controller = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
