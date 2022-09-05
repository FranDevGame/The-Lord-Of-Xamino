using UnityEngine;
using UnityEngine.UI;

public class UILifeController : MonoBehaviour
{
    public static UILifeController instance;

    [SerializeField] Image hearth1, hearth2, hearth3;

    [SerializeField] Sprite hearthFull, hearthEmpty;

    [SerializeField] Text coinText;

    UILifeController uILifeController;

    public Image fadeScreen;
    public float fadeSpeed;
    [SerializeField] bool shouldFadeToBlack, shouldFadeFromBlack;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateCoinCount();
        //FadeFromBlack();
    }

   

    public void UpdateHealthDisplay()
    {
        switch (PlayerLife.instance.currerntHealh)
        {
            case 3:
                hearth1.sprite = hearthFull;
                hearth2.sprite = hearthFull;
                hearth3.sprite = hearthFull;

                break;

            case 2:

                hearth1.sprite = hearthFull;
                hearth2.sprite = hearthFull;
                hearth3.sprite = hearthEmpty;

                break;

            case 1:

                hearth1.sprite = hearthFull;
                hearth2.sprite = hearthEmpty;
                hearth3.sprite = hearthEmpty;

                break;

            case 0:

                hearth1.sprite = hearthEmpty;
                hearth2.sprite = hearthEmpty;
                hearth3.sprite = hearthEmpty;

                break;

            default:

                hearth1.sprite = hearthEmpty;
                hearth2.sprite = hearthEmpty;
                hearth3.sprite = hearthEmpty;

                break;
        }
    }

    public void UpdateCoinCount()
    {
        coinText.text = PickUp.pickupInstance.coinsCollected.ToString();
    }

}
