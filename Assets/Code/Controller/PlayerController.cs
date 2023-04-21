using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TDCore.BaseControllers;

public class PlayerController : MonoModule
{
    public override void Destroy()
    {
        base.Destroy();

        Destroy(gameObject);
    }
}