using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectEnterUIHandler : MonoBehaviour
{
    public GameObject uiGameObject;
    private XRSocketInteractor socketInteractor;

    private void Awake()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
    }

    private void OnEnable()
    {
        if (socketInteractor != null && uiGameObject != null)
        {
            socketInteractor.selectEntered.AddListener(DisplayUI);
            socketInteractor.selectExited.AddListener(HideUI);
        }
    }

    private void OnDisable()
    {
        if(socketInteractor != null)
        {
            socketInteractor.selectEntered.RemoveListener(DisplayUI);
            socketInteractor.selectExited.RemoveListener(HideUI);
        }
    }

    void DisplayUI(SelectEnterEventArgs args)
    {
        uiGameObject.SetActive(true);
        Invoke("HideUI", 2f);
    }

    void HideUI()
    {
        if (uiGameObject.activeSelf)
        {
            uiGameObject.SetActive(false);
        }
    }

    void HideUI(SelectExitEventArgs args)
    {
        CancelInvoke("HideUI");
        HideUI();
    }
}