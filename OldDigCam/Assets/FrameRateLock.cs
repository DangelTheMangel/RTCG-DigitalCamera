using UnityEngine;

public class FrameRateLock : MonoBehaviour
{
    public int frameLock = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 24;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
