using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPoint;
    public FlyingCube flyingCubePrefab;
    public InputField timeField;
    public InputField distanceField;
    public InputField speedField;

    public double time { get; private set; }
    public int speed { get; private set; }
    public int distance { get; private set; }
    double maxTime;

    void Start()
    {
        distance = 1600;
        speed = 3;
        maxTime = 3;
        time = maxTime;

        timeField.text = time.ToString();
        distanceField.text = distance.ToString();
        speedField.text = speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            time = maxTime;
            FlyingCube cube = Instantiate<FlyingCube>(flyingCubePrefab, spawnPoint.position, Quaternion.identity);
            cube.spawnPoint = spawnPoint;
            cube.cubeSpawner = this;
        }
    }

    public void SetMaxTime()
    {
        maxTime = Convert.ToDouble(timeField.text);
    }

    public void SetDistance()
    {
        distance = Convert.ToInt32(distanceField.text);
    }

    public void SetSpeed()
    {
        speed = Convert.ToInt32(speedField.text);
    }
}
