using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class LocomotionController : MonoBehaviour
{
    public XRController rightTeleportRay;
    public InputHelpers.Button TeleportActivationButton;
    public XRController leftTeleportRay;
    public float activationThreshold = 0.1f;

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, TeleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var xrInteractorLineVisualRight = rightTeleportRay.GetComponent<XRInteractorLineVisual>();
        xrInteractorLineVisualRight.gameObject.SetActive(CheckIfActivated(rightTeleportRay));

        var xrInteractorLineVisualLeft = leftTeleportRay.GetComponent<XRInteractorLineVisual>();
        xrInteractorLineVisualLeft.gameObject.SetActive(CheckIfActivated(leftTeleportRay));


    }
}
