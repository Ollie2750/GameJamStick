using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text stickCountText;
    public int stickCount = 0;

    void Start()
    {
        stickCountText.text = ("Sticks: " + stickCount);
    }


    void Update()
    {
        
    }

    public void AddStick()
    {
        stickCount += 1;
        stickCountText.text = ("Sticks: " + stickCount);
    }

    public int BurnSticks()
    {
        int burntAmount = stickCount;
        stickCount = 0;
        stickCountText.text = ("Sticks: " + stickCount);
        return burntAmount;
    }
}
