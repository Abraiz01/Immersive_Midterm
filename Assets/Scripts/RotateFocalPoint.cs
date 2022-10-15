using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFocalPoint : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset;

    public float rotationSpeed;

    // Calling LateUpdate so that the camera updates after the dog moves
    void LateUpdate()
    {  
        // add an offset so that the camera is positioned on top of the dog
        transform.position = player.transform.position + offset;

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
