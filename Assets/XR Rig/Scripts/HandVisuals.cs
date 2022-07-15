using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandVisuals : MonoBehaviour
{
    [SerializeField] private Animator handAnimator;
    [SerializeField] private string gripButtonName;

    void Update()
    {
        if(Input.GetButtonDown(gripButtonName))
        {
            handAnimator.SetBool("Gripped", true);
        }

        if(Input.GetButtonUp(gripButtonName))
        {
            handAnimator.SetBool("Gripped", false);
        }
    }
}
