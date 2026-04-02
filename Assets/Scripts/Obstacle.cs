using UnityEngine;

public class Obstacle : MonoBehaviour
{
    LevelManager levelmanager;

    private void Awake()
    {
        levelmanager = FindFirstObjectByType<LevelManager>();
    }

    private void FixedUpdate()
    {
        if (levelmanager.CurrentGameState != GameState.Running)
            return;

        transform.position += Vector3.back * levelmanager.GetSpeed() * Time.fixedDeltaTime;
    }

    //public float GetSpeed()
    //{
    //    return speed;
    //}

    //public void SetSpeed(float newSpeed)
    //{
    //    speed = newSpeed;
    //}

}
