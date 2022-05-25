using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereCase : MonoBehaviour
{
    public TMP_Text cubeCountText;
    HookController hookController;
    public int sphereCount;
    
    private void Start()
    {
        hookController = GameObject.Find("Hook").GetComponent<HookController>();
    }

    private void Update()
    {
        sphereCountControl();  
    }

    private void sphereCountControl()
    {
        if (sphereCount >= 10)
        {
            StartCoroutine(PassDelay());
        }
    }

    IEnumerator PassDelay()
    {
        yield return new WaitForSeconds(2);
        hookController.canPass = true;
    }
}
