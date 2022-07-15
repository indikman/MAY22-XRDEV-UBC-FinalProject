using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class PushButton : XRSimpleInteractable
{
    public UnityEvent onPressed;
    public UnityEvent onReleased;

    [SerializeField] private GameObject buttonObject;
    [SerializeField] private Transform upPosition, downPosition;

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        buttonObject.transform.position = downPosition.position;

        onPressed.Invoke();
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);

        buttonObject.transform.position = upPosition.position;

        onReleased.Invoke();

    }
}
