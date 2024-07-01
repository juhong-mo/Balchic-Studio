using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    private bool ButtonDown;

    private float xPos;
    private float yPos;
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonDown = false;

        xPos = 200;
        yPos = 200;

        Vector3 newPos = new Vector3(xPos, yPos);

        transform.position = newPos;
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
