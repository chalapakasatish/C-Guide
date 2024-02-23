using UnityEngine;

public class Coin : Collectible
{
    public int coins;
    public override void Collect()
    {
        coins++;
        Debug.Log("Coin collected! " + coins);
    }
    public override void Destroy()
    {
        Destroy(gameObject);
    }
}

