using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // to test code
        Player player = new Player(100);
        player.TakeDamage(20);

        Projectile Projectile = new Projectile(0);
        Projectile.Fire(); // depending on the previous line, the output will be different

        ScoreTracker Score = new ScoreTracker(50);
        Debug.Log("Score: " + Score.GetScore()); // 50
        Score.ResetScore();
        Debug.Log("New Score: " + Score.GetScore()); // 0
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
    private int health; // change to private and add getter method

    public Player(int health)
    {
        this.health = health;
    }

    public void TakeDamage(int amount)
    {
        int newhealth = this.health - amount;
        if (newhealth < 0)
        {
            this.health = 0;
            Debug.Log("Player health: " + this.health + "(" + newhealth + ")");
        }
    }

    public int GetHealth()
    {
        return this.health;
    }
}

public class ScoreTracker
{
    private int score; // change to private and add getter method

    public ScoreTracker(int score)
    {
        this.score = score;
    }

    public int GetScore()
    {
        return this.score;
    }

    public void ResetScore()
    {
        this.score = 0;
    }
}