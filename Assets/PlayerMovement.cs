using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerGoals goals;

    public CharacterController controller;
    public Light flashLight;

    public float speed = 12f;
    public float jumpHeight = 1f;
    public float weight = 10f;

    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;

    float gravity = -9.81f;
    Vector3 velocity;

    private void Start()
    {
        goals.AddGoal("Get up!");
        goals.AddGoal("Turn on flashlight");
    }


    // Update is called once per frame
    void Update()
    {
        var isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity * weight);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            goals.CompleteGoal("Turn on flashlight");
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime * weight;

        controller.Move(velocity * Time.deltaTime * Time.deltaTime);


    }
} 