using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{


    [SerializeField] GameObject coin;

   

    public void SpawnRewardCoin()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
