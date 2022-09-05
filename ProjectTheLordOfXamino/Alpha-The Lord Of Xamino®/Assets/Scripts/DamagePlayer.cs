using UnityEngine;

public class DamagePlayer : MonoBehaviour

{
    


    public static DamagePlayer instance;


    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Player")
        {
            PlayerLife.instance.currerntHealh--;
            
            Debug.Log("hit");

            PrototypeHero.instance.KnocBackPlayer();

            UILifeController.instance.UpdateHealthDisplay();
            
            //Llama a ProtoTypeHero y ejecuta el método KnocBackPlayer para que ejecute la animación del KnocBack

            //PlayerLife.instance.PlayerDamage(); //Ejecuta el método PlayerDamage que resta un punto de vida y actualiza los corazones.
        }

        
    }

    



    
}
