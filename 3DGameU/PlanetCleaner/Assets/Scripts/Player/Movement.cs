using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 walkDirection;
    
    private CharacterController _characterController;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        walkDirection = transform.right * x + transform.forward * z; 
    }

    private void FixedUpdate()
    {
        Walk(walkDirection); 
    }

    private void Walk(Vector3 direction)
    {
        _characterController.Move(direction * speed * Time.fixedDeltaTime);
    }
}
