using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class t : MonoBehaviour
{   
    
    
    public int n=0;
    public int f=3;
   

    public void Goo(){
    
        if (n<f)
        {
            n=n+1;
            Debug.Log(n);
            SceneManager.LoadScene(0);
         
        }

        if(n==f)
        {
            SceneManager.LoadScene(1);
        }
    }
}