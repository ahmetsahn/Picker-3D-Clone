using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ufo : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    HookController hookController;
    private bool goRightPos = true;
    private bool goRightPos2 = false;
    private bool goRightPos3 = false;
    private bool goForwardPos =false;
    private bool goForwardPos2 = false;
    private bool goForwardPos3 = false; 
    private bool goForwardPos4 = false;
    private bool goLeftPos = false;
    private bool goLeftPos2 = false;
    private bool goUpPos = false;
    private bool instantiateSphere = true;
    

    private void Start()
    {
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (hookController.canPass2)
        {
            if (goRightPos)
            {
                StartCoroutine(SecondMove());
                Vector3 rightPos = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, rightPos, Time.deltaTime * 10);
            }

            else if (goForwardPos)
            {
                StartCoroutine(ThirdMove());
                Vector3 forwardPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
                transform.position = Vector3.MoveTowards(transform.position, forwardPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goLeftPos)
            {
                StartCoroutine(FourthMove());
                Vector3 leftPos = new Vector3(transform.position.x - 4, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, leftPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue2());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goForwardPos2)
            {
                StartCoroutine(FifthMove());
                Vector3 forwardPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
                transform.position = Vector3.MoveTowards(transform.position, forwardPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goRightPos2)
            {
                StartCoroutine(SixthMove());
                Vector3 midPos = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, midPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue2());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goForwardPos3)
            {
                StartCoroutine(SeventhMove());
                Vector3 forwardPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
                transform.position = Vector3.MoveTowards(transform.position, forwardPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goLeftPos2)
            {
                StartCoroutine(EighthMove());
                Vector3 leftPos = new Vector3(transform.position.x - 4, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, leftPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue2());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goForwardPos4)
            {
                StartCoroutine(NinthMove());
                Vector3 forwardPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
                transform.position = Vector3.MoveTowards(transform.position, forwardPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goRightPos3)
            {
                StartCoroutine(TenthMove());
                Vector3 midPos = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, midPos, Time.deltaTime * 10);

                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue2());
                    Instantiate(spherePrefab, transform.position, Quaternion.identity);
                    instantiateSphere = false;
                }
            }

            else if (goUpPos)
            {
                StartCoroutine(DestroyPlane());
                Vector3 upPos = new Vector3(transform.position.x, transform.position.y + 40, transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, upPos, Time.deltaTime * 20);
            }
        }
    }

    IEnumerator SecondMove()
    {
        yield return new WaitForSeconds(0.15f);
        goRightPos = false;
        goForwardPos = true;
    }

    IEnumerator ThirdMove()
    {
        yield return new WaitForSeconds(0.5f);
        goForwardPos = false;
        goLeftPos = true;
    }

    IEnumerator FourthMove()
    {
        yield return new WaitForSeconds(0.3f);
        goLeftPos=false;
        yield return new WaitForSeconds(0.2f);
        goForwardPos2 = true;
    }


    IEnumerator FifthMove()
    {
        yield return new WaitForSeconds(0.5f);
        goForwardPos2 = false;
        goRightPos2 = true;
    }

    IEnumerator SixthMove()
    {
        yield return new WaitForSeconds(0.3f);
        goRightPos2=false;
        yield return new WaitForSeconds(0.2f);
        goForwardPos3 = true;
    }

    IEnumerator SeventhMove()
    {
        yield return new WaitForSeconds(0.5f);
        goForwardPos3 = false;
        goLeftPos2 = true;
    }

    IEnumerator EighthMove()
    {
        yield return new WaitForSeconds(0.3f);
        goLeftPos2 = false;
        yield return new WaitForSeconds(0.2f);
        goForwardPos4 = true;
    }

    IEnumerator NinthMove()
    {
        yield return new WaitForSeconds(0.5f);
        goForwardPos4 = false;
        goRightPos3 = true;
    }

    IEnumerator TenthMove()
    {
        yield return new WaitForSeconds(0.3f);
        goRightPos3 = false;
        yield return new WaitForSeconds(0.2f);
        goUpPos = true;
    }

    IEnumerator DestroyPlane()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }

    IEnumerator InstantiateTrue()
    {
        yield return new WaitForSeconds(0.07f);
        instantiateSphere = true;
    }

    IEnumerator InstantiateTrue2()
    {
        yield return new WaitForSeconds(0.13f);
        instantiateSphere = true;
    }
}
