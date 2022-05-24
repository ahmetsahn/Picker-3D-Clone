using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassGround3 : MonoBehaviour
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
        if (hookController.canPass3)
        {
            Vector3 firsPos = transform.position;
            Vector3 lastPos = new Vector3(transform.position.x, 0, transform.position.z);
            transform.position = Vector3.MoveTowards(firsPos, lastPos, Time.deltaTime * 4);
        }
    }
}
