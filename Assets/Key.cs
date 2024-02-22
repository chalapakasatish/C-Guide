using UnityEngine;

public class Key : Collectible
{
    public int keys;
    public override void Collect()
    {
        keys++;
        Debug.Log("Key collected! " + keys);
    }

    public override void Destroy()
    {
        Destroy(gameObject);
    }
}
