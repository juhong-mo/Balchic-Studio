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

    private float timer;
    private static float Timelimit = 20.0f;
    private Text textTimer;

    private LeftButton leftbutton;
    private RightButton rightbutton;

    private Creature creature;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(creature.GetHP() >= 0)
        {
            creature.gameObject.SetActive(false);
        }

        if(calcShownTimer() <= 0)
        {
            if(creature.GetHP() > 0)
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
