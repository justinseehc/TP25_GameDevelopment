using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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

public class Projectile
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
        }
        else
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