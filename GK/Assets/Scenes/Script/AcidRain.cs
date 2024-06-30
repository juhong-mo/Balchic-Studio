using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARFoundation;

public class AcidRain : MonoBehaviour
{
    private Vector3 wPos;
    private Vector3 lPos;

    private Vector3 rainPos;

    // Start is called before the first frame update
    void Start()
    {
        wPos = GetComponent<ARSessionOrigin>().camera.transform.position;
        lPos = GetComponent<ARSessionOrigin>().camera.transform.localPosition;

        rainPos = wPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        wPos = GetComponent<ARSessionOrigin>().camera.transform.position;
        lPos = GetComponent<ARSessionOrigin>().camera.transform.localPosition;
    }
}
