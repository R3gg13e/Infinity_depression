using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float Speed
    {
        get { return speed; }
        set { speed = value;}
    }

    public float SpawnDelay
    {
        get { return spawnDelay; }
        set { spawnDelay = value; }
    }

    [SerializeField] float speed = 5f;
    [SerializeField] float spawnDelay = 5f;

    private void FixedUpdate()
    {
        transform.position += Vector3.back * speed * Time.fixedDeltaTime;
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
