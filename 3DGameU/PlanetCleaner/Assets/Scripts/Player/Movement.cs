using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 walkDirection;
    public Animator _animator;

    private CharacterController _characterController;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        walkDirection = transform.right * x + transform.forward * z; 
        if(x > 0.1f || x < -0.1f || z > 0.1f || z < -0.1f)
        {
            _animator.Play("PlayerAnim");
        }
        else
        {
            _animator.Play("Idle");
        }
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
