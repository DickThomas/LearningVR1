using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class weapon : MonoBehaviour
{
    private XRGrabInteractable interactable = null;
    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
        
    }

    private void OnEnable()
    {
        interactable.onActivate.AddListener(Fire);
    }


    private void OnDisable()
    {
        interactable.onActivate.RemoveListener(Fire);
    }
    private void Fire(XRBaseInteractor interactor)
    {
        Debug.Log("fire");
    }


}
