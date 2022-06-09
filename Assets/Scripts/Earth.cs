using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject Planet;
    public GameObject Atmosphere;
    public GameObject Moon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Planet.transform.Rotate(0, -0.07f, 0);
        Atmosphere.transform.Rotate(0,-0.1f, 0);
        Moon.transform.Rotate(0, -0.07f, 0);
        Moon.transform.RotateAround(Planet.transform.position,
            Vector3.up+Vector3.right,
            -0.07f);
    }
}
