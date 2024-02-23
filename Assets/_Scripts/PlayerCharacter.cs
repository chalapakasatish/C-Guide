using Unity.VisualScripting;
using UnityEngine;

public class PlayerCharacter : Character
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Player Start");
    }

    protected override void Update()
    {
        //base.Update();
        //Debug.Log("Player Update");
    }
}
