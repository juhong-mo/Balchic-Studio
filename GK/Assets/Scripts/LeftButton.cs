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

    public void OnMouseDown()
    {
        if (ButtonDown == true)
        {
            moveLeft();
        }
    }

    //

    private void moveLeft()
    {

    }

    private void PointerDown()
    {
        ButtonDown = true;
    }
}
