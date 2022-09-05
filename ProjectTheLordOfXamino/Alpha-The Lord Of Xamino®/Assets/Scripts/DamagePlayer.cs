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
            
            //Llama a ProtoTypeHero y ejecuta el m�todo KnocBackPlayer para que ejecute la animaci�n del KnocBack

            //PlayerLife.instance.PlayerDamage(); //Ejecuta el m�todo PlayerDamage que resta un punto de vida y actualiza los corazones.
        }

        
    }

    



    
}
