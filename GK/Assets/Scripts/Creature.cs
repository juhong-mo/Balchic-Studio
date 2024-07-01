using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;

public class Creature : MonoBehaviour
{
    private static float speed = 5f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    private int HP;

    //private Vector3 currPos;

    // Start is called before the first frame update
    //private Vector3 initPos = new Vector3(0, 0.5f, 3.3f);

    private void Awake()
    {
        
    }

    void Start()
    {
        UnityEngine.Vector3 fixedPoint = 
            GetComponent<ARSessionOrigin>().camera.transform.position + new UnityEngine.Vector3(0f, 0f, 900f);

        transform.position = fixedPoint;

        HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingLeft == true)
        {
            moveLeft();
        }

        if (isMovingRight == true)
        {
            moveRight();
        }
    }

    //move
    public void moveRight()
    {
        Debug.Log("right!");
        transform.Translate(UnityEngine.Vector3.right * Time.deltaTime * speed);
    }

    public void moveLeft()
    {
        Debug.Log("left!");
        transform.Translate(UnityEngine.Vector3.left * Time.deltaTime * speed);
    }

    public void OnLeftButtonDown()
    {
        isMovingLeft = true;
    }

    public void OnLeftButtonUp()
    {
        isMovingLeft = false;
    }

    public void OnRightButtonDown()
    {
        isMovingRight = true;
    }

    public void onRightButtonUp()
    {
        isMovingRight = false;
    }


    //trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rain"))
        {
            HP -= 1;
        }
    }


    public int GetHP()
    {
        return HP;
    }
}