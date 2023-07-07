using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttttttttt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        int n=0;
        int s1=5;
        int s2=8;
        int s3=2;
        int s4=4;
        
        int[] arr1={s1,s2,s3,s4};
        for(int i=0;i<4;i++)
        {
            
            if(arr1[i]>5)
            {
                Debug.Log(arr1[i]+"passed the exam");
                n++;
            }
            
        }
        Debug.Log(n+"students passed the exam");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
