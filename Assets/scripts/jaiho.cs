using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class jaiho: MonoBehaviour
{
 
    public Text scoreT;
    public int score;
 

    // Start is called before the first frame update
    void Start()
    {
 
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            score++;
            Debug.Log(score);
            scoreT.text = score.ToString();    
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            score--;
            Debug.Log(score);
            scoreT.text = score.ToString();
        }
 
    }
}
