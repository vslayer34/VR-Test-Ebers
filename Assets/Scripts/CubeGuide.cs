using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CubeGuide : MonoBehaviour
{
    // Unity Events Loop Methods-------------------------------------------------------------------

    public void ShowVideoPlayer(SelectEnterEventArgs args)
    {
        Debug.Log("Show video");
    }

    public void HideVideoPlayer(SelectExitEventArgs args)
    {
        Debug.Log("hide video");
    }
}
