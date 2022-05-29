using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoint : MonoBehaviour
{
    private float verticalSpeed = 5;
    HookController hookController;

    private void Start()
    {
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }

    private void FixedUpdate()
    {
        HookStopControl();
    }

    private void HookStopControl()
    {
        if (hookController.stop == false)
        {
            transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);
        }
    }
}
