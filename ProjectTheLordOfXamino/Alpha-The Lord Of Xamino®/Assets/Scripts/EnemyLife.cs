using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    [SerializeField] float life;

    [SerializeField] Animator animator;

    [SerializeField] SpawnerCoins spawnerCoins;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GetDamage(float damgEnemy)
    {
        life = life - damgEnemy;

        if (life == 0)
        {
            EnemyDeath();

            Invoke ("SpawnRewardCoinToKylan", 1.5f);

            Destroy(gameObject, 2f);
        }

    }

    public void EnemyDeath()
    {
        animator.SetTrigger("Death");

        //To Do Ponerle sonido de que destruye el enemigo

    }

    private void SpawnRewardCoinToKylan()
    {
        spawnerCoins.SpawnRewardCoin();
    }
}
