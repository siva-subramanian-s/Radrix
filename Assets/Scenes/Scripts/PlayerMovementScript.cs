using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float playerSpeed = 2.0f;
    public CharacterController controller;
    private Vector3 playerVelocity;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x + transform.forward * y);
        controller.Move(move  * playerSpeed * Time.deltaTime);
    }
}
