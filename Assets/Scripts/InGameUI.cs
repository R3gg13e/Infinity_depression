using UnityEngine;
using TMPro;
public class InGameUI : MonoBehaviour
{
    [Header("UI elements")]
    [SerializeField] TMP_Text timeSurvivedTextObject;
    [SerializeField] TMP_Text speedTextObject;
    [SerializeField] TMP_Text endStatsTextObject;

    [SerializeField] GameObject hud;
    [SerializeField] GameObject gameOverScreen;

    private LevelManager levelManager;

    private void Awake()
    {
        levelManager = FindFirstObjectByType<LevelManager>();
    }

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }
    private void Update()
    {
        if (levelManager.CurrentGameState == GameState.Running)
        {
            UpdateTimeText();
            UpdateSpeedText();
        }
    }

    private void UpdateTimeText()
    {
        timeSurvivedTextObject.text = $"Time survived: \n{levelManager.GameTime:F2}";
    }

    private void UpdateSpeedText()
    {
        speedTextObject.text = $"Speed: \n{levelManager.GetSpeed()}";

        if (levelManager.GetSpeed() > 7)
            speedTextObject.color = Color.red ;

    }

    public void DisplayGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        hud.SetActive(false);

        endStatsTextObject.text = $"you survived for \n{levelManager.GameTime} seconds";
    }


}
