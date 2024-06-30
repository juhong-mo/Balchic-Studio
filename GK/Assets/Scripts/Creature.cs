using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Creature : MonoBehaviour
{
    private static float speed = 0.05f;

    // Start is called before the first frame update
    private Vector3 initPos = new Vector3(0, 0.5f, 3.3f);
    void Start()
    {
        transform.position = initPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0.5f, 3.3f);
    }

    private void moveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void moveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
