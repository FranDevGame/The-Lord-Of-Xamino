using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KylanAttack : MonoBehaviour
{
    [SerializeField] Transform AttackControll;
    [SerializeField] float radiusAttack;
    [SerializeField] float damageAttack;


    private void Update()
    {
     
        if (Input.GetMouseButtonDown(0))
        {
            Attack();

            
        }

       
    }

    private void Attack()
    {

        PrototypeHero.instance.KylanAttack();

        Collider2D[] objetcs = Physics2D.OverlapCircleAll(AttackControll.position, radiusAttack);

        foreach (Collider2D colisionador in objetcs)
        {
            if (colisionador.CompareTag("Enemy"))
            {
                colisionador.transform.GetComponent<EnemyLife>().GetDamage(damageAttack);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackControll.position, radiusAttack);
    }
}
