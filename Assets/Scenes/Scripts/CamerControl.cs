using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CamerControl : MonoBehaviour {
    public float mouseSensitivity = 100f;
    public float xRotation = 0f;
    public Transform player;
    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime ;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime ;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        player.Rotate(Vector3.up * mouseX);
    }
}
