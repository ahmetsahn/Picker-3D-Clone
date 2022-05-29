using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MonoBehaviour
{
    [SerializeField] private GameObject leftCylinder;
    [SerializeField] private GameObject rightCylinder;
    private float horizontalInput;
    private float horizontalSpeed=7;
    private float verticalSpeed = 7;
    private float xRange = 2.2f;
    private float sphereCaseStopPosition = 53f;
    private float sphereCase2StopPosition = 123f;
    private float sphereCase3StopPosition = 183.4f;
    public bool canPass;
    public bool canPass2;
    public bool canPass3;
    public bool stop;

    void FixedUpdate()
    {
        StopControl();
        PositionControl();
    }

    private void StopControl()
    {
        if (stop == false)
        {
            HookMove();
        }

        if (stop)
        {
            CylinderClose();
        }
    }

    private void CylinderClose()
    {
        leftCylinder.SetActive(false);
        rightCylinder.SetActive(false);
    }

    private void PositionControl()
    {
        if (transform.position.z > sphereCaseStopPosition)
        {
            stop = true;
            CanPassControl();
        }

        if (transform.position.z > sphereCase2StopPosition)
        {
            stop = true;
            CanPass2Control();
        }

        if (transform.position.z > sphereCase3StopPosition)
        {
            stop = true;
            CanPass3Control();
        }
    }

    private void HookMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * horizontalSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    private void CanPassControl()
    {
        if (canPass)
        {
            stop = false;
        }
    }

    private void CanPass2Control()
    {
        if (canPass2)
        {
            stop = false;
        }
    }

    private void CanPass3Control()
    {
        if (canPass3)
        {
            stop = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Buffer"))
        {
            Destroy(other.gameObject);
            leftCylinder.SetActive(true);
            rightCylinder.SetActive(true);
        }
    }
}
