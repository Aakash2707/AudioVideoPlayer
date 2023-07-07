using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; 
using UnityEngine.UI; 

public class vidplay : MonoBehaviour
{
    public VideoPlayer videoPlayer;     
    public void playVideo(){         
        videoPlayer = GetComponent<VideoPlayer>();               
        videoPlayer.Play();  
    } 
}
