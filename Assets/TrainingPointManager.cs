using UnityEngine;

public class TrainingPointManager : MonoBehaviour
{
    void Start()
    {
        GameObject vrCameraRig = GameObject.FindWithTag("MainCamera");
        if (vrCameraRig != null)
        {
            vrCameraRig.transform.position = SceneLoader.targetLocation;
        }
        else
        {
            Debug.LogError("VR Camera Rig not found. Make sure it's tagged correctly.");
        }
    }
}