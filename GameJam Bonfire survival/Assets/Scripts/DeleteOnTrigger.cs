using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit");
        Destroy(gameObject);
    }
}

