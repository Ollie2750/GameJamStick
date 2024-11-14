using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject ground;
    [SerializeField] private int groundSize;
    [SerializeField] private int tileSize;

    private List<GameObject[]> world = new List<GameObject[]>();

    void Start()
    {
        //Create spawn chunk (1,1)

    }

    void Update()
    {
        
    }

}
