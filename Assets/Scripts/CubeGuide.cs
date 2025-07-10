using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CubeGuide : MonoBehaviour
{
    private Material _defaultSkyBox;

    [SerializeField]
    private Material _stereoscopicSkyBox;



    // Unity Events Loop Methods-------------------------------------------------------------------
    
    private void Start()
    {
        _defaultSkyBox = RenderSettings.skybox;
    }

    public void ShowVideoPlayer(SelectEnterEventArgs args)
    {
        Debug.Log("Show video");
        RenderSettings.skybox = _stereoscopicSkyBox;
        UIManager.Instance.PlayVideo();
    }

    public void HideVideoPlayer(SelectExitEventArgs args)
    {
        Debug.Log("hide video");
        RenderSettings.skybox = _defaultSkyBox;
        UIManager.Instance.PauseVideo();
    }
}
