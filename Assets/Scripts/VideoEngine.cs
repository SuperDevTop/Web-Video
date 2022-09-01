using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEngine : MonoBehaviour
{
    public VideoPlayer videoPlayer;   
    public GameObject landScapeScreen;
    public GameObject portraitScreen;
    bool isDectected = false;

    void Start()
    {        
    }

    void Update()
    {        
        if (Screen.width >= Screen.height)
        {                     
            landScapeScreen.transform.localScale = new Vector3(Screen.width / 2532f, Screen.height / 1170f, 1f);
        }
        else
        {                      
            portraitScreen.transform.localScale = new Vector3(Screen.width / 1170f, Screen.height / 2532f, 1f);
        }

        if (isDectected)
        {
            if (Screen.width >= Screen.height)
            {
                landScapeScreen.SetActive(true);
                portraitScreen.SetActive(false);
            }
            else
            {
                landScapeScreen.SetActive(false);
                portraitScreen.SetActive(true);
            }
        }
    }   

    public void DetectGravity()
    {        
        isDectected = true;
        videoPlayer.url = Application.streamingAssetsPath + "/gravity.mp4";
        videoPlayer.Play();
    }

    public void Lost()
    {
        isDectected = false;
        landScapeScreen.SetActive(false);
        portraitScreen.SetActive(false);
        videoPlayer.Stop();
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }

    public void PauseVideo()
    {
        videoPlayer.Pause();
    }
}
