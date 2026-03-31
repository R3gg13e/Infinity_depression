using System;
using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float currentGameSpeed = 5f;

    private void Start()
    {
        StartCoroutine(GraduallySpeedUpTime());
    }

    IEnumerator GraduallySpeedUpTime()
    {
        while (true)
        {
           //Wait a bit
           yield return new WaitForSeconds(3f);
           currentGameSpeed += 0.25f;

        }
       

    }
    public float GetSpeed()
    {
        return currentGameSpeed;
    }

    internal void CoinCollected()
    {
        throw new NotImplementedException();
    }
}
