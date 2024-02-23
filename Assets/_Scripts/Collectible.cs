using UnityEngine;

public abstract class Collectible : MonoBehaviour, IInteractable
{
    public abstract void Collect();
    public abstract void Destroy();

    public void Interact()
    {
        Collect();
        Destroy();
    }
}
