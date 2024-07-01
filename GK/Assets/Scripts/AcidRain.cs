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

    ParticleSystem ps;
    List<ParticleSystem.Particle> inside = new List<ParticleSystem.Particle>();

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
    }

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
        this.transform.position = wPos;
    }

    private void FixedUpdate()
    {
        wPos = GetComponent<ARSessionOrigin>().camera.transform.position;
        lPos = GetComponent<ARSessionOrigin>().camera.transform.localPosition;
    }

    private void OnParticleTrigger()
    {
        Debug.Log("Effet Trigger");
        ps.GetTriggerParticles(ParticleSystemTriggerEventType.Inside, inside);

        foreach(var v in inside)
        {
            Debug.Log("Effect Trigger2");
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log($"Effect Collision : {other.name}");
    }
}
