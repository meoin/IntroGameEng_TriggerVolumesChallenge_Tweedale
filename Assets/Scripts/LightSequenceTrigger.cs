using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightSequenceTrigger : MonoBehaviour
{
    private bool triggered = false;
    private List<GameObject> spotlights = new List<GameObject>();
    private List<GameObject> pointlights = new List<GameObject>();
    private int targetLight;
    private float spotLightIntensity = 0;
    public float maxSpotLightIntensity = 25;
    private float pointLightIntensity = 0;
    public float maxPointLightIntensity = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++) 
        {
            if (i % 2 == 0)
            {
                spotlights.Add(transform.GetChild(i).gameObject);
            }
            else 
            {
                pointlights.Add(transform.GetChild(i).gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetLight < spotlights.Count) 
        {
            if (triggered)
            {
                spotLightIntensity = Mathf.Min(spotLightIntensity + 0.05f, maxSpotLightIntensity);
                pointLightIntensity = Mathf.Min(pointLightIntensity + 0.001f, maxPointLightIntensity);
            }

            spotlights[targetLight].GetComponent<Light>().intensity = spotLightIntensity;
            pointlights[targetLight].GetComponent<Light>().intensity = pointLightIntensity;

            if (spotlights[targetLight].GetComponent<Light>().intensity == maxSpotLightIntensity)
            {
                spotLightIntensity = 0;
                pointLightIntensity = 0;
                targetLight++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
    }
}
