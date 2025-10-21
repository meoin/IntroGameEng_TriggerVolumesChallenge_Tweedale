using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public GameObject spotLight;
    public GameObject pointLight;
    private bool triggered = false;
    private float spotLightIntensity = 0;
    public float maxSpotLightIntensity = 25;
    private float pointLightIntensity = 0;
    public float maxPointLightIntensity = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //light.GetComponent<Light>().intensity = intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered) 
        {
            spotLightIntensity = Mathf.Min(spotLightIntensity + 0.05f, maxSpotLightIntensity);
            pointLightIntensity = Mathf.Min(pointLightIntensity + 0.001f, maxPointLightIntensity);
        }

        spotLight.GetComponent<Light>().intensity = spotLightIntensity;
        pointLight.GetComponent<Light>().intensity = pointLightIntensity;
    }

    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
    }
}
