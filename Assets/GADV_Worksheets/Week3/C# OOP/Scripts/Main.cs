using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Player.cs
        Player player = new Player(100);
        player.TakeDamage(20);

        Projectile Projectile = new Projectile(0);
        Projectile.Fire(); // depending on the previous line, the output will be different

        ScoreTracker Score = new ScoreTracker(50);
        Debug.Log("Score: " + Score.GetScore()); // 50
        Score.ResetScore();
        Debug.Log("New Score: " + Score.GetScore()); // 0

        // TreasureChest.cs
        TreasureChest chest = new TreasureChest(); 
        chest.Shake();

        AncientChest ancientChest = new AncientChest();
        ancientChest.Unlock();

        MagicChest magicchest = new MagicChest();
        magicchest.Unlock();

        chest.Unlock(true);
        chest.Unlock(false);

        ScoreManager scoremgr = new ScoreManager();
        scoremgr.AddScore(10);
        Debug.Log("Score: " + scoremgr.GetScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}