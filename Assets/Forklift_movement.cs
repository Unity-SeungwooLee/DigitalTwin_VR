using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
public class Forklift_movement : MonoBehaviour
{
    public Transform tr_lever;
    public bool isKeycont;
    public Transform lever;
    public Transform wheelRot;
    public float wheelRotY;
    public float moveSpeed;
    public float rotSpeed;
    public XRLever xrLever;
    //float wheelRotY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (moveSpeed != 0)
        //{
        //    if (lever.localEulerAngles.x > 50 && lever.localEulerAngles.x < 40)
        //    {
        //        moveSpeed -= 0.1f;
        //        if (moveSpeed <= 0)
        //        {
        //            moveSpeed = 0;
        //        }
        //    }
        //}
        if (lever.localEulerAngles.x > 310 && lever.localEulerAngles.x < 360)
        {
            moveSpeed += 0.01f;
            if (moveSpeed > 2f)
            {
                moveSpeed = 2f;
            }
        }
        else if (lever.localEulerAngles.x > 0 && lever.localEulerAngles.x < 40)
        {
            moveSpeed -= 0.01f;
            if (moveSpeed < -1f)
            {
                moveSpeed = -1f;
            }
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            wheelRotY -= 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            wheelRotY += 1f;
        }
        Move();
        WheelRot();
        if (isKeycont == true)
        {
            Keycont();
        }

    }
    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); ;
    }
    void WheelRot()
    {
        wheelRot.localEulerAngles = new Vector3(0, wheelRotY, 0);
        transform.localRotation = Quaternion.Euler(0, transform.localRotation.y + wheelRotY, 0);
    }
    void Keycont()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveSpeed += 0.1f;
            if (moveSpeed > 2f)
            {
                moveSpeed = 2f;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveSpeed -= 0.1f;
            if (moveSpeed < -1f)
            {
                moveSpeed = -1f;
            }
        }
        else
        {
            if (moveSpeed > 0)
            {
                moveSpeed -= 0.01f;
                if (moveSpeed <= 0)
                {
                    moveSpeed = 0;
                }
            }
            else if (moveSpeed < 0)
            {
                moveSpeed += 0.01f;
                if (moveSpeed >= 0)
                {
                    moveSpeed = 0;
                }
            }
        }
    }
}
