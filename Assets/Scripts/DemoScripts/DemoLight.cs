using UnityEngine;
using System.Collections;

public class DemoLight : MonoBehaviour
{

    private Light spotLight;

    private void Awake()
    {
        spotLight = GetComponent<Light>();
    }
    private void Start()
    {
        spotLight.intensity = 0f;

        StartCoroutine(SlowlyTurnOn());
    }

    IEnumerator SlowlyTurnOn()
    {

        while (spotLight.intensity < 100f)
        {
            yield return new WaitForSeconds(0.05f);
            spotLight.intensity += 1f;
        }

        spotLight.intensity = 100f;

    }

}
