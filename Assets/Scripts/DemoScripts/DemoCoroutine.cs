using UnityEngine;
using System.Collections;

public class DemoCoroutine : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(WaitForABit(2f));
    }

    IEnumerator WaitForABit(float delayInSeconds)
    {
        Debug.Log("I'm going to wait");
        yield return new WaitForSeconds(delayInSeconds);
        Debug.Log("I'm done waiting");

    }

}
