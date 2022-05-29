using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassGround : PassGroundBase
{
    HookController hookController;
   
    private void Start()
    {
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }

    private void Update()
    {
        canPassControl();
    }

    private void canPassControl()
    {
        if (hookController.canPass)
        {
            MovePassGround();
        }
    }
}

