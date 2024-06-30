using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MiniGames
{
    main = 0,
    tutorial,
    map,
    shooting,
    rain,
    seed,
    flower,
    memory
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public MiniGames currState = MiniGames.main;

    public static int cleared;
    public static int life;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
