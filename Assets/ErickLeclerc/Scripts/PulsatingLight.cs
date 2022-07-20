using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsatingLight : MonoBehaviour
{
    public float intensityA;
    public float intensityB;
    public float pulsatingSpeed;
    public float newIntensity;

    [SerializeField] private new Light light;
    

    private void Awake()
    {
        newIntensity = light.intensity;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       light.intensity = Mathf.Lerp(intensityA,intensityB, Mathf.PingPong(Time.time * pulsatingSpeed,1));
    }
}
