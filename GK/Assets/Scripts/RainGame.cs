using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public enum minigameState
{
    Start = 0,
    GameOver
}
public class RainGame : MonoBehaviour
{
    private static bool valid = true;

    private int HP;
    private float timer;
    private static float Timelimit = 20.0f;
    private Text textTimer;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        HP = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(calcShownTimer() <= 0)
        {
            if(HP > 0)
            {
                valid = false;
            }
        }
    }

    private float calcShownTimer()
    {
        return Timelimit - timer;
    }

    public void ShowTimer()
    {
        textTimer = GetComponent<Text>();
        textTimer.text = string.Format("{0:F1}",  calcShownTimer());
    }

    public bool isValid()
    {
        return valid;
    }

    private void onTriggerEnger(Collider other)
    {
        if (other.CompareTag("Rain"))
        {
            
        }
    }
}
