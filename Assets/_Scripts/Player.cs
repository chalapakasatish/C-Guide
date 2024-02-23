using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour,IDamageable
{
    public void TakeDamage(int damage)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IInteractable interactable))
        {
            interactable.Interact();
            
        }
    }
}


