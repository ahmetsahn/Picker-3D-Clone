using System.Collections;
using UnityEngine;

public class Ufo : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    HookController hookController;
    public bool goRightPos = true;
    public bool goRightPos2 = false;
    public bool goRightPos3 = false;
    public bool goForwardPos =false;
    public bool goForwardPos2 = false;
    public bool goForwardPos3 = false; 
    public bool goForwardPos4 = false;
    public bool goLeftPos = false;
    public bool goLeftPos2 = false;
    public bool goUpPos = false;
    private bool instantiateSphere = true;
    private float speed = 8;
    private bool canMove = true;




    private void Start()
    {
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }

    void FixedUpdate()
    {
        Move();
        MoveControl();
    }

    private void MoveControl()
    {
        if (hookController.canPass2 && canMove)
        {
            StartCoroutine(AllMove());
            canMove = false;
        }
    }

    private void Move()
    {
        if (hookController.canPass2 && goRightPos)
        {

            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }

        else if (goForwardPos)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goLeftPos)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goForwardPos2)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goRightPos2)
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goForwardPos3)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goLeftPos2)
        {

            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goForwardPos4)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goRightPos3)
        {

            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (instantiateSphere)
            {
                StartCoroutine(InstantiateTrue());
                InstantiateSphere();
            }
        }

        else if (goUpPos)
        {

            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

    private void InstantiateSphere()
    {  
        Instantiate(spherePrefab, transform.position, Quaternion.identity);
        instantiateSphere = false;
    }

    IEnumerator AllMove()
    {
        yield return new WaitForSeconds(0.25f);
        goRightPos = false;
        
        goForwardPos = true;
        yield return new WaitForSeconds(0.7f);
        goForwardPos = false;
        
        goLeftPos = true;
        yield return new WaitForSeconds(0.5f);
        goLeftPos = false;
        
        goForwardPos2 = true;
        yield return new WaitForSeconds(0.7f);
        goForwardPos2 = false;
        
        goRightPos2 = true;
        yield return new WaitForSeconds(0.5f);
        goRightPos2 = false;
        
        goForwardPos3 = true;
        yield return new WaitForSeconds(0.7f);
        goForwardPos3 = false;
        
        goLeftPos2 = true;
        yield return new WaitForSeconds(0.5f);
        goLeftPos2 = false;
        
        goForwardPos4 = true;
        yield return new WaitForSeconds(0.7f);
        goForwardPos4 = false;
        
        goRightPos3 = true;
        yield return new WaitForSeconds(0.5f);
        goRightPos3 = false;
        goUpPos = true;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    

   

  
    IEnumerator InstantiateTrue()
    {
        yield return new WaitForSeconds(0.1f);
        instantiateSphere = true;
    }


    

    
}
