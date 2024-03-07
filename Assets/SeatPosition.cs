using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatPosition : MonoBehaviour
{
    public bool isSeat;
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = Vector3.zero;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isSeat == false)
        {
            if (other.name == "XR Origin (XR Rig)")
            {
                isSeat = true;
                camera.transform.parent = transform;
                camera.transform.localPosition = Vector3.zero;
            }
        }
    }
}
