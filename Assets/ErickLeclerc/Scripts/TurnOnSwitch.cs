using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class TurnOnSwitch : XRSimpleInteractable
{
    [SerializeField] Transform positionOff, positionOn;

    [SerializeField] private GameObject lightSwitchObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        StartCoroutine(LightSwitch());

        
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);

        lightSwitchObject.transform.position = positionOn.transform.position;


    }

    IEnumerator LightSwitch()
    {
        lightSwitchObject.transform.position = positionOn.transform.position;

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("SecondSceneTester");
    }


           
}
