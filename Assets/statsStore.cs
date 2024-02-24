using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsStore : MonoBehaviour
{
    public static int deaths;
    public static int points;
    public static int highScore;
    public static int kills;
    public static int ammo;
    public static int swings;
    public static int shotsFired;
    public static int enemies;
    public static int roomsComplete;
    public static int roomsSeen;
    public static int roomsSkipped;
    public static int charactersUnlocked;

    public static statsStore S;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
