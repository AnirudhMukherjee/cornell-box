using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        int totalCubes = 14;
        float totalDistance = 2f;

        for (int i = 0; i < totalCubes; i++)
        {
            float perc = (float)i / (float)totalCubes;
            float sin = Mathf.Sin(perc*Mathf.PI/2);
            float x = 1.5f+ sin * totalDistance;
            float y = 6f;
            float z = 0.0f;
            var newCube = (GameObject)Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<Spin>().SetSize(0.5f* (1.0f-perc));
            newCube.GetComponent<Spin>().rotateSpeed = 0.2f+ perc*1.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
