using UnityEngine;

public class FrameRateLock : MonoBehaviour
{
    public int frameLock = 60;

    void Start()
    {
        QualitySettings.vSyncCount = 0; 
        Application.targetFrameRate = frameLock;
    }

    void Update()
    {
        
    }
}
