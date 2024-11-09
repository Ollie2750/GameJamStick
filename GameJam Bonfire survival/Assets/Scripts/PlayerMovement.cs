using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 movement = new Vector3(0,0,0);
    private Vector2 tempMovement;
    public int speed;


    public GameManager gameManager;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidbody.velocity = movement * speed;

    }

    private void OnMovement(InputValue value)
    {
        tempMovement = value.Get<Vector2>();
        movement.x = tempMovement.x;
        movement.z = tempMovement.y;
        rigidbody.velocity += movement;
    }

    void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name.Split(" ")[0];
        if (name == "Stick")
        {
            Destroy(other.gameObject);
            gameManager.AddStick();
        }
    }
}