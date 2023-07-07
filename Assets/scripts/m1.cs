using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m1: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }
    public float moveSpeed=5;
    // Update is called once per frame
    void Update()
    {
       float moveHorizontal = Input.GetAxis("Horizontal");
       float moveVertical = Input.GetAxis("Vertical");
       Vector3 movement = new Vector3(moveHorizontal,0f,moveVertical);
       transform.Translate(movement* Time.deltaTime *moveSpeed);
     
                   
    }
}
