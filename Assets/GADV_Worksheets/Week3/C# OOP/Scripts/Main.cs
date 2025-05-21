using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Player player = new Player(10);
        //player.TakeDamage(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Projectile : MonoBehaviour
{
    private float speed;
    public Projectile(float speed)
    {
        this.speed = speed;
    }

    public void Fire()
    {
        if (this.speed > 0)
        {
            Debug.Log("Firing projectile at speed " + speed);
        } else
        {
            Debug.Log("Cannot fire: speed too low.");
            AutoFire();
        }
    }

    public void AutoFire()
    {
        if (this.speed == 0)
        {
            this.speed = 100;
            Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
        }
    }
}

public class Player
{
    private int health;

    public Player(int health)
    {
        this.health = health;
    }

    public void TakeDamage(int amount)
    {
        this.health -= amount;
    }

    public int GetHealth()
    {
        return this.health;
    }
}

public class ScoreTracker
{
    public int score;

    public ScoreTracker(int score)
    {
        this.score = score;
    }


    public void ResetScore()
    {
        this.score = 0;
    }
}