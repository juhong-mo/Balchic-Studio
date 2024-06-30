using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour
{
    private bool ButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonDown == true)
        {
            MoveRight();
        }
    }

    //public void OnMouseDown()
    //{
        
    //}

    //

    private void MoveRight()
    {

    }

    public void PointerDown()
    {
        ButtonDown = true;
    }
}
