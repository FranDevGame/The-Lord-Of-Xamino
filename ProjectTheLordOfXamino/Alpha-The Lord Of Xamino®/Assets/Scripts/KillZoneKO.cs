using UnityEngine;

public class KillZoneKO : MonoBehaviour
{
    public static KillZoneKO killZoneInstance;

    private void Awake()
    {
        killZoneInstance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            PlayerLife.instance.currerntHealh = 0;

            PrototypeHero.instance.DeathKylan();

            UILifeController.instance.UpdateHealthDisplay();

            Invoke("UploadLifeBeforeDeathKO", 2.4f);
            Debug.Log("Corazones");

        }

    }

    public void UploadLifeBeforeDeathKO()
    {
        PlayerLife.instance.currerntHealh = PlayerLife.instance.maxHealth;
        Debug.Log("Spawn Con Toda La Vida");

        UILifeController.instance.UpdateHealthDisplay(); //TO DO Rellenar
    }

}
