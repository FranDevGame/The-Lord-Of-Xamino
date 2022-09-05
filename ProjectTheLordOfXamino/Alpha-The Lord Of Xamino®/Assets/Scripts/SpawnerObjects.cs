using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{

    public static SpawnerObjects spawncoinInstance;

    [SerializeField] GameObject bullet; //Declaramos una variable de clase, de tipo GameObject con nombre cloud.

    [SerializeField] float powerBullet = 5f;

    [SerializeField] float counter;




    private void Awake()
    {
        spawncoinInstance = this;
    }

    private void Update()
    {
        SpawnBullet();
    }

    //public void SpawnRewardCoin()
    //{
    //    Instantiate(coin, transform.position, Quaternion.identity);
    //}

    public void SpawnBullet()
    {

        counter++; //
        if (counter % 1000 == 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);


        }


    }

}
