using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections.Generic;
using System.Linq;
  
public class aaa : MonoBehaviour
{
    static int LucasSequence(int []arr, int n) 
    {
        int max = arr.Max(); 
        int counter = 0; 
        HashSet<int> s = new HashSet<int>() ;
          
        int a = 2, b = 1 ;
        s.Add(a); 
        s.Add(b); 
          
        while (b < max) 
        { 
            int c = a + b; 
            a = b; 
            b = c; 
            s.Add(b); 
        } 
      
        for (int i = 0; i < n; i++) 
        { 
      
            if (s.Contains(arr[i]))
                counter++; 
        } 
        return counter; 
    } 
  
    static public void Main() 
    { 
        int []arr = { 7, 11, 22, 4, 2, 1, 8, 9 }; 
        int n = arr.Length ;

        Console.WriteLine(LucasSequence(arr, n)) ;
        Debug.Log (arr[6]);
    } 
}
