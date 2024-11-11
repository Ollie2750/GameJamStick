using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject stick;
    public GameObject tree;
    private int treeHight;

    public TMP_Text stickCountText;
    public int stickCount = 0;

    void Start()
    {
        stickCountText.text = ("Sticks: " + stickCount);
        for (int i = 0; i < UnityEngine.Random.Range(1500, 3000); i++)
        {
            int x = UnityEngine.Random.Range(-300, 300);
            int z = UnityEngine.Random.Range(-300, 300);
            if (!(10 > x && x > -10 && 10 > z && z > -30))
            {
                treeHight = UnityEngine.Random.Range(5, 10);
                GameObject tempTree = Instantiate(tree, new Vector3(x, treeHight / 2, z), Quaternion.identity);
                tempTree.transform.localScale = new Vector3(1, treeHight, 1);
            }
        }
        for (int i = 0; i < UnityEngine.Random.Range(5000, 20000); i++)
        {
            int x = UnityEngine.Random.Range(-300, 300);
            int z = UnityEngine.Random.Range(-300, 300);
            GameObject tempStick = Instantiate(stick, new Vector3(x, 0.001f, z), Quaternion.identity);
        }
    }


    void Update()
    {
        
    }

    private void OnCloseGame(InputValue input)
    {
        Debug.Log("Quit");
        Application.Quit();
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

    public void LostGame()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
