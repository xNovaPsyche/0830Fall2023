using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehaviour : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("Late Start");

        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on Start");
        }
    }
}
