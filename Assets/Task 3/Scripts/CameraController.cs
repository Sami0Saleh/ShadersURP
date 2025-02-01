using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;  
    public float lookSpeed = 2f;  

    private float yaw = 0f;  
    private float pitch = 0f; 

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; 
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;   

        transform.Translate(moveX, 0, moveZ);

        // Mouse Look (Hold Right Click to Rotate)
        if (Input.GetMouseButton(1)) 
        {
            yaw += lookSpeed * Input.GetAxis("Mouse X");
            pitch -= lookSpeed * Input.GetAxis("Mouse Y");
            pitch = Mathf.Clamp(pitch, -90f, 90f); 

            transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
        }
    }
}
