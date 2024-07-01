using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    private bool ButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        ButtonDown = true;
    }

    private void OnMouseUp()
    {
        ButtonDown = false;
    }

    public bool IsButtonDown()
    {
        return ButtonDown;
    }
}
