using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class table : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n=1;
        for(int j=1;j<=10;j++)
        {
            Debug.Log(j*n);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
