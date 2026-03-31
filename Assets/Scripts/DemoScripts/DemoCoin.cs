using UnityEngine;

public class DemoCoin : MonoBehaviour
{

    [SerializeField] Transform coinObject;

    private DemoLevelManager levelManager;

    private void Awake()
    {
        //Find the level manager in the level
        levelManager = FindFirstObjectByType<DemoLevelManager>();
    }

    private void Update()
    {
        coinObject.Rotate(new Vector3(0f, 25f * Time.deltaTime, 0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Coin was collected, inform the manager
            levelManager.CoinCollected();

            // Then the coin get's destroyed
            Destroy(this.gameObject);

        }
    }

}
