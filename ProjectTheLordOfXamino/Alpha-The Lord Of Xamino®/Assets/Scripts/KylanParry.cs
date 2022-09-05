using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KylanParry : MonoBehaviour
{
    [SerializeField] Transform parryControl;
    [SerializeField] float radiusDefense;



    private void Update()
    {

        Parry();

    }

    private void Parry()
    {

        PrototypeHero.instance.ParryKylan();

        Collider2D[] objetcs = Physics2D.OverlapCircleAll(parryControl.position, radiusDefense);

        foreach (Collider2D colisionador in objetcs)
        {
            if (colisionador.CompareTag("Bullet"))
            {
                Destroy(colisionador.gameObject);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(parryControl.position, radiusDefense);
    }
}
