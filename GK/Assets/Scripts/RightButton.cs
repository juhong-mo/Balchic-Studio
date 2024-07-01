using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    private bool ButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        ButtonDown = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointerDown()
    {
        Debug.Log("Button Down!");
        ButtonDown = true;
    }

    public void PointerUp()
    {
        Debug.Log("Button Up!");
        ButtonDown = false;
    }

    public bool IsButtonDown()
    {
        return ButtonDown;
    }
}