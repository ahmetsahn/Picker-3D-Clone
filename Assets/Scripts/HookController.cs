using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MonoBehaviour
{
    [SerializeField] private GameObject leftCylinder;
    [SerializeField] private GameObject rightCylinder;
    private float verticalSpeed = 5;
    private float xRange = 2.2f;
    private float sphereCaseStopPosition = 53f;
    private float sphereCase2StopPosition = 123f;
    private float sphereCase3StopPosition = 183.4f;
    public bool canPass;
    public bool canPass2;
    public bool canPass3;
    public bool stop;
    private bool touching;
    Vector3 lastPos;

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
      
        transform.Translate(Vector3.forward * verticalSpeed * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touching = true;

            if (touching)
            {
                lastPos = new Vector3((Camera.main.ScreenToViewportPoint(touch.position).x - 0.5f) * 8.8f, transform.position.y, transform.position.z);

                // Camera.main.ScreenToViewportPoint(touch.position) takes a value between 0 and 1
                // When the player is at 0, Camera.main.ScreenToViewportPoint(touch.position) is at 0.5
                // So 0.5 is subtracted
                // The player can move between -4 and 4 on the x-axis. Difference 4.4. So it is multiplied by 4.4 but multiplied by 8.8 for better gameplay
                // You need to arrange these numbers according to yourself.
                // Example : The range your player can move on the x-axis is -5 to 5. Difference 10. So it is multiplied by 10.

                transform.position = Vector3.Lerp(transform.position, lastPos, Time.deltaTime * 3);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                touching = false;
            }
        }

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
