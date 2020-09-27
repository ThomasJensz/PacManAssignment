using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int currentScore = 1234;

    public GameObject ScoreSprite1;
    public GameObject ScoreSprite10;
    public GameObject ScoreSprite100;
    public GameObject ScoreSprite1000;

    public GameObject Zero;
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    public GameObject Seven;
    public GameObject Eight;
    public GameObject Nine;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateDisplay()
    {
        string stringScore = currentScore.ToString();
        GameObject ScoreSprite1 = getNumber(stringScore[]);
    }

    void getNumber(string n) 
    {
        switch (n)
        {
            case "0":
                return Zero;
                break;
        }
    }
}
