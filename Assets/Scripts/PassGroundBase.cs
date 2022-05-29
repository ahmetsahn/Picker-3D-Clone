using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassGroundBase : MonoBehaviour
{
    public void MovePassGround()
    {
        Vector3 firsPos = transform.position;
        Vector3 lastPos = new Vector3(transform.position.x, 0, transform.position.z);
        transform.position = Vector3.MoveTowards(firsPos, lastPos, Time.deltaTime * 4);
    }
}
