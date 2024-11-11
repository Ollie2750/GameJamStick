using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Update()
    {
        this.transform.position = player.transform.position + offset;
    }
}
