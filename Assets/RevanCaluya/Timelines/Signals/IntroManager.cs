using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    [SerializeField] private GameObject _trainConductor;

    public void RevealConductor()
    {
        _trainConductor.SetActive(true);
    }
}
