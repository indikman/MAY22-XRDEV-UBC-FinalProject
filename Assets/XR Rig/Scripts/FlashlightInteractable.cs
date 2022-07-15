using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashlightInteractable : XRGrabInteractable
{
    [SerializeField] private GameObject lightObject;
    [SerializeField] private MeshRenderer flashLightGlass;
    [SerializeField] private Material lightOn, lightOff;
    [SerializeField] private GameObject beam1, beam2;

    private bool isOn = false;

    void ToggleLight()
    {
        if(isOn)
        {
            // Turn the light off
            lightObject.SetActive(false);
            flashLightGlass.material = lightOff;
            beam1.SetActive(false);
            beam2.SetActive(false);

            isOn = false;
        }
        else
        {
            // Turn the light on
            lightObject.SetActive(true);
            flashLightGlass.material = lightOn;
            beam1.SetActive(true);
            beam2.SetActive(true);

            isOn = true;
        }
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        ToggleLight();
    }
}
