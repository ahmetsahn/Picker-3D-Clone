using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Transform hook;
    SphereCase sphereCase;
    SphereCase2 sphereCase2;
    SphereCase3 sphereCase3;
    HookController hookController;
    Rigidbody rb;
    MeshRenderer meshRenderer;
    private bool collisionOn = true;
    private bool addForceOn = true;
    private float thrust = 2.5f;

    private void Awake()
    {
        hook = GameObject.Find("Hook").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        sphereCase = GameObject.Find("Sphere Case").GetComponent<SphereCase>();
        sphereCase2 = GameObject.Find("Sphere Case 2").GetComponent<SphereCase2>();
        sphereCase3 = GameObject.Find("Sphere Case 3").GetComponent<SphereCase3>();
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }
   
    private void Update()
    {
        AddForceControl();
        HookOffsetControl();
    }

    private void AddForceControl()
    {
        if (hookController.stop && addForceOn)
        {
            PositionControl();
        }
    }

    private void HookOffsetControl()
    {
        if(hook.position.z - transform.localPosition.z > 30)
        {
            Destroy(gameObject);
        }
    }

    private void PositionControl()
    {
        if (transform.localPosition.z > 28 && transform.localPosition.z < 32)
        {
            StartCoroutine(AddForceFinisher());
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }

        if (transform.localPosition.z > 98 && transform.localPosition.z < 102)
        {
            StartCoroutine(AddForceFinisher());
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }

        if (transform.localPosition.z > 178 && transform.localPosition.z < 182)
        {
            StartCoroutine(AddForceFinisher());
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SphereCase") && collisionOn)
        {
            StartCoroutine(setColor());
            collisionOn = false;
            Destroy(gameObject, 2f);
        }

        if(collision.gameObject.CompareTag("SphereCase2") && collisionOn)
        {
            StartCoroutine(setColor2());
            collisionOn = false;
            Destroy(gameObject, 2);
        }

        if (collision.gameObject.CompareTag("SphereCase3") && collisionOn)
        {
            StartCoroutine(setColor3());
            collisionOn = false;
            Destroy(gameObject, 2);
        }
    }

    IEnumerator AddForceFinisher()
    {
        yield return new WaitForSeconds(0.03f);
        addForceOn = false;
    }

    IEnumerator setColor()
    {
        yield return new WaitForSeconds(1);
        meshRenderer.material.color = Color.green;
        sphereCase.sphereCount++;
        sphereCase.cubeCountText.text = sphereCase.sphereCount + "/ 10";
        collisionOn = true;
    }

    IEnumerator setColor2()
    {
        yield return new WaitForSeconds(1);
        meshRenderer.material.color = Color.green;
        sphereCase2.sphereCount++;
        sphereCase2.cubeCountText.text = sphereCase2.sphereCount + "/ 20";
    }

    IEnumerator setColor3()
    {
        yield return new WaitForSeconds(1);
        meshRenderer.material.color = Color.green;
        sphereCase3.sphereCount++;
        sphereCase3.cubeCountText.text = sphereCase3.sphereCount + "/ 30";
    }
}
