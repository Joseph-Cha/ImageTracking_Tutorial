using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageRecognitionTest : MonoBehaviour
{
    private ARTrackedImageManager arTrackedImageManager;

    private void Awake()
    {
        arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        arTrackedImageManager.trackedImagesChanged -= OnImageChanged;

    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
