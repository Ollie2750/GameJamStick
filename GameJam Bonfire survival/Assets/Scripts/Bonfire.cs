using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody rigidbody;

    private float fuelGiven = 0f;
    public float fuelCost;
    public float fuelUsePerFrame;
    private float fuel = 3f;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.transform.localScale = new Vector3(fuel, fuel, fuel);
        rigidbody.transform.position = new Vector3(0,fuel/2 + 0.01f, 0);
    }

    void FixedUpdate()
    {
        if (fuelGiven <= 0f)
        {
            fuelGiven = 0f;
        } else if (fuelGiven > 2f)
        {
            fuel += fuelUsePerFrame * 2;
            fuelGiven -= fuelCost;
        }
        else
        {
            fuel += fuelUsePerFrame;
            fuelGiven -= fuelCost;
        }
        fuel -= fuelUsePerFrame;
        if (fuel <= 0)
        {
            gameManager.LostGame();
        }
        else if (fuel > 10)
        {
            rigidbody.transform.localScale = new Vector3(10, 10, 10);
            rigidbody.transform.position = new Vector3(0, 5 + 0.01f, 0);
        }
        else 
        {
            rigidbody.transform.localScale = new Vector3(fuel, fuel, fuel);
            rigidbody.transform.position = new Vector3(0, fuel / 2 + 0.01f, 0);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        fuelGiven += gameManager.BurnSticks();
    }
}
