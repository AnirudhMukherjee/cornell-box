using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    public Vector3 spin = Vector3.zero;
    public float size1 = 1.5f;
    public Vector3 spinAxis = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        //SetSize(size);
        //transform.position = new Vector3(0, 5, 3);
        spin = new Vector3(Random.value, Random.value, Random.value);
        spinAxis.x = Random.Range(-1, 1)*.1f;
    }

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(spin);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);
    }
}
