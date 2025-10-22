using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public Transform spawner;
    public GameObject childPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(childPrefab, spawner.position, spawner.rotation);
    }
}
