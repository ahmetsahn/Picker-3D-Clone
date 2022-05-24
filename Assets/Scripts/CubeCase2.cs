using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeCase2 : MonoBehaviour
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
        if (sphereCount >= 20)
        {
            StartCoroutine(PassDelay2());
        }
    }

    IEnumerator PassDelay2()
    {
        yield return new WaitForSeconds(2f);
        hookController.canPass2 = true;
    }
}
