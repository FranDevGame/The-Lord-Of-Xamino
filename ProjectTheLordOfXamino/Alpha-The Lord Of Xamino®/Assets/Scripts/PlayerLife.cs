using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public float currerntHealh;
    public float maxHealth;
    public float zeroLife = 0f;
    [SerializeField] SpriteRenderer sPrD2d;
   
    


    public static PlayerLife instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currerntHealh = maxHealth;

        sPrD2d = GetComponent<SpriteRenderer>();
    }

    public void HealPlayer()
    {
        currerntHealh++;
        if (currerntHealh > maxHealth)
        {
            currerntHealh = maxHealth;
        }

        UILifeController.instance.UpdateHealthDisplay();
    }


    //public void PlayerDamage()
    //{
    //    currerntHealh--; //Resta un punto de vida

    //    UILifeController.instance.UpdateHealthDisplay(); //Actualiza los corazones de la UI de vida.
    //}

    //public void RespawnKylan()
    //{
    //    PrototypeHero.instance.RespawnHero(); //traete el método de ProtoTypeHero y ejecuta el método RespawnHero.
    //}


 

}
