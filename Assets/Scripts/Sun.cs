using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject Earth;
    public GameObject Venus;
    public GameObject Mars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, -0.05f, 0);
        Earth.transform.RotateAround(
            transform.position,
            Vector3.up,
            -0.02f);
        Venus.transform.RotateAround(
            transform.position,
            Vector3.up,
            -0.02f);
        Mars.transform.RotateAround(
            transform.position,
            Vector3.up,
            -0.02f);
    }
}
