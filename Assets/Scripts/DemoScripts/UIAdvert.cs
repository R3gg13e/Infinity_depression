using TMPro;
using UnityEngine;

public class UIAdvert : MonoBehaviour
{
    [SerializeField] TMP_Text offerExpiresTextObject;
    [SerializeField] GameObject headlineTextObject;
    [SerializeField] GameObject soldTextObject;
    [SerializeField] GameObject offerTextObject;
    [SerializeField] float offerDuration = 5f;
    private float offerTimer;


    private void Start()
    {
        offerTimer = offerDuration;
        soldTextObject.SetActive(false);
    }
    private void Update()
    {
        //reduce time from offer timer
        offerTimer -= Time.deltaTime;

        if (offerTimer < 0)
        {
            soldTextObject.SetActive(true);
            headlineTextObject.SetActive(true) ;
            offerTextObject.SetActive(false);
        }
        else
        {
            UpdateOfferTimerText(offerTimer);

        }
    }
    private void UpdateOfferTimerText(float timeLeft)
    {
        offerExpiresTextObject.text = $"Offer expires in {timeLeft}";


    }
}
