using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject imageTexture;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoPlayer.loopPointReached += VideoFinished;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //imageTexture.SetActive(true);
        videoPlayer.Play();
    }

    void VideoFinished(VideoPlayer vp) 
    {
        Application.Quit();
    }
}
