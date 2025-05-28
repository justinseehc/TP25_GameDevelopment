using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    void Start()
    {
        Shake();
        AncientChest ancientChest = new AncientChest();
        ancientChest.Unlock();

        MagicChest magicchest = new MagicChest();
        magicchest.Unlock(); // print different message
    }

    public virtual void Unlock() { }
    public void Shake() 
    {
        Debug.Log("You hear something rattle inside the chest.");
    }
}

public class AncientChest : TreasureChest
{
    public override void Unlock() 
    {
        Debug.Log("You unlock the ancient chest with an ancient key.");
    }
}
public class MagicChest : TreasureChest
{
    public override void Unlock() 
    {
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
}