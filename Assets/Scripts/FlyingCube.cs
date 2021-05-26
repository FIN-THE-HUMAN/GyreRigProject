using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCube : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPoint;
    public CubeSpawner cubeSpawner;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((spawnPoint.position - transform.position).magnitude > cubeSpawner.distance) Destroy(gameObject);
        transform.Translate(0, 0, cubeSpawner.speed);
    }
}
