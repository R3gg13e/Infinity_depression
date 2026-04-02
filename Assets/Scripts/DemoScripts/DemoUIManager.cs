using UnityEngine;
using TMPro;

public class DemoUIManager : MonoBehaviour
{
    [SerializeField] TMP_Text coinsTextObject;

    
    public void UpdateCoinsText(int numberOfCoins)
    {
        coinsTextObject.text = $"Coins:{numberOfCoins}";
    }
}
