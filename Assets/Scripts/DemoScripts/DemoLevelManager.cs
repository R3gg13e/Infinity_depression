using UnityEngine;

public class DemoLevelManager : MonoBehaviour
{
    // Get access to the game manager
    [SerializeField] DemoGameManagerSO gameManager;
    private DemoUIManager demouiManager;

    private void Awake()
    {
        demouiManager = FindFirstObjectByType<DemoUIManager>();
    }

    private void Start()
    {
        //reset settings
        gameManager.Reset();
    }

    public void CoinCollected()
    {
        //Player has collected a coin, let's inform game manager and the ui manager
        gameManager.collectedCoins += 1;
        demouiManager.UpdateCoinsText(gameManager.collectedCoins);
    }
}
