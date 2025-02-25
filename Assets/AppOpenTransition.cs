using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppOpenTransition : MonoBehaviour
{
     public CanvasGroup appOpenCanvasGroup; // App Open Screen
    public GameObject appOpenScreen; // Full UI Panel
    public GameObject welcomeScreen; // The Next Screen

    void Start()
    {
        Invoke("HideAppOpenScreen", 1.2f); // Adjust timing to match animation duration
    }

    void HideAppOpenScreen()
    {
        appOpenCanvasGroup.blocksRaycasts = false; // Prevent clicking on it
        appOpenScreen.SetActive(false); // Hide the App Open screen
        welcomeScreen.SetActive(true); // Show the Welcome Screen
    }
}
