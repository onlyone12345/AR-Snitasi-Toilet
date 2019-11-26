using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class VideoControl : MonoBehaviour
{
   
    public VideoPlayer videoPlayer1;
    public VideoPlayer videoPlayer2;
    public VideoPlayer videoPlayer3;

    public AudioSource audioSource;

    public GameObject playButton;
    public GameObject pauseButton;
    public GameObject mainCanvas;

    bool isTracked = false;
    // Start is called before the first frame update


    void Start()
    {
        //dissableAll();
    }

    private void Update()
    {
        if (isTrackingMarker("ImageTarget1") || isTrackingMarker("ImageTarget2"))
        {
            mainCanvas.SetActive(true);
        }
        else
        {
            PauseVideo();
        }
    }


    public void PlayVideo()
    { 
        videoPlayer1.GetComponent<VideoPlayer>().Play();
        videoPlayer2.GetComponent<VideoPlayer>().Play();
        videoPlayer3.GetComponent<VideoPlayer>().Play();

        pauseButton.SetActive(true);
        playButton.SetActive(false);
        audioSource.GetComponent<AudioSource>().Play();
        Debug.Log("Play");
       
    }

    public void PauseVideo()
    {
        mainCanvas.SetActive(false);
        videoPlayer1.GetComponent<VideoPlayer>().Pause();
        videoPlayer2.GetComponent<VideoPlayer>().Pause();
        videoPlayer3.GetComponent<VideoPlayer>().Pause();

        pauseButton.SetActive(false);
        playButton.SetActive(true);
        audioSource.GetComponent<AudioSource>().Pause();
    }

    public void StopVideo()
    {

    }

    public void dissableAll()
    {
        mainCanvas.SetActive(false);
    }

    private bool isTrackingMarker(string imageTargetName)
    {
        var imageTarget = GameObject.Find(imageTargetName);
        var trackable = imageTarget.GetComponent<TrackableBehaviour>();
        var status = trackable.CurrentStatus;
        return status == TrackableBehaviour.Status.TRACKED;
    }

    private bool ChangeStateTrackced()
    {
        bool rere = false;
        if (isTrackingMarker("ImageTarget1") || isTrackingMarker("ImageTarget2"))
        {
            rere = true;
        }

        return rere;
    }
}
