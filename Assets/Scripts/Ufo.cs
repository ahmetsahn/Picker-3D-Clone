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
    private float speed = 7;




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
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            else if (goForwardPos)
            {
                StartCoroutine(ThirdMove());
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goLeftPos)
            {
                StartCoroutine(FourthMove());
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goForwardPos2)
            {
                StartCoroutine(FifthMove());
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goRightPos2)
            {
                StartCoroutine(SixthMove());
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goForwardPos3)
            {
                StartCoroutine(SeventhMove());
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
              
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goLeftPos2)
            {
                StartCoroutine(EighthMove());
                transform.Translate(Vector3.left * speed * Time.deltaTime);
               
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goForwardPos4)
            {
                StartCoroutine(NinthMove());
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goRightPos3)
            {
                StartCoroutine(TenthMove());
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                
                if (instantiateSphere)
                {
                    StartCoroutine(InstantiateTrue());
                    InstantiateSphere();
                }
            }

            else if (goUpPos)
            {
                StartCoroutine(DestroyPlane());
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
    }

    private void InstantiateSphere()
    {
        Vector3 instantiatePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(spherePrefab, instantiatePos, Quaternion.identity);
        instantiateSphere = false;
    }

    IEnumerator SecondMove()
    {
        yield return new WaitForSeconds(0.3f);
        goRightPos = false;
        yield return new WaitForSeconds(0.15f);
        goForwardPos = true;
 
    }

    IEnumerator ThirdMove()
    {
        yield return new WaitForSeconds(0.7f);
        goForwardPos = false;
        yield return new WaitForSeconds(0.15f);
        goLeftPos = true;
    }

    IEnumerator FourthMove()
    {
        yield return new WaitForSeconds(0.6f);
        goLeftPos=false;
        yield return new WaitForSeconds(0.15f);
        goForwardPos2 = true;
    }


    IEnumerator FifthMove()
    {
        yield return new WaitForSeconds(0.7f);
        goForwardPos2 = false;
        yield return new WaitForSeconds(0.15f);
        goRightPos2 = true;
    }

    IEnumerator SixthMove()
    {
        yield return new WaitForSeconds(0.6f);
        goRightPos2=false;
        yield return new WaitForSeconds(0.15f);
        goForwardPos3 = true;
    }

    IEnumerator SeventhMove()
    {
        yield return new WaitForSeconds(0.7f);
        goForwardPos3 = false;
        yield return new WaitForSeconds(0.15f);
        goLeftPos2 = true;
    }

    IEnumerator EighthMove()
    {
        yield return new WaitForSeconds(0.6f);
        goLeftPos2 = false;
        yield return new WaitForSeconds(0.15f);
        goForwardPos4 = true;
    }

    IEnumerator NinthMove()
    {
        yield return new WaitForSeconds(0.7f);
        goForwardPos4 = false;
        yield return new WaitForSeconds(0.15f);
        goRightPos3 = true;
    }

    IEnumerator TenthMove()
    {
        yield return new WaitForSeconds(0.6f);
        goRightPos3 = false;
        goUpPos = true;
    }

    IEnumerator DestroyPlane()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    IEnumerator InstantiateTrue()
    {
        yield return new WaitForSeconds(0.1f);
        instantiateSphere = true;
    }

    

    
}
