using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement.Normalize();

        if (movement.magnitude > 0)
        {
            // Calculate rotation towards movement direction
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Apply movement
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // Set animator parameters
            animator.SetFloat("Speed", moveSpeed);
        }
        else
        {
            // Set animator parameters
            animator.SetFloat("Speed", 0f);
        }
    }
}
