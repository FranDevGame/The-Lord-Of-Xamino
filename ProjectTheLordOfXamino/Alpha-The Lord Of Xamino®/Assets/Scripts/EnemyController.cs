using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float velocity;
    
    [SerializeField] Transform floorController;

    [SerializeField] Transform wallController;


    [SerializeField] float distance;

    [SerializeField] float wallDistance;

    [SerializeField] bool movingRight;

    [SerializeField] Rigidbody2D rb2D;

    

    private void Update()
    {
        CheckFloor();

        CheckWall();

        rb2D.velocity = new Vector2(velocity, 0);
    }

    private void Rotate()
    {
        movingRight = !movingRight;

        //transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);

        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

        velocity *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(wallController.transform.position, wallController.transform.position + Vector3.right * wallDistance);
        Gizmos.DrawLine(floorController.transform.position, floorController.transform.position + Vector3.down * distance);
    }

    public void CheckFloor()
    {
        RaycastHit2D infoFloor = Physics2D.Raycast(floorController.position, Vector2.down, distance);

        if (infoFloor == false)
        {
            
            Rotate();
        }
    }

    public void CheckWall()
    {
        RaycastHit2D infoWall;


        if (movingRight)
        {
             infoWall = Physics2D.Raycast(wallController.position, Vector2.right, wallDistance);
            // if(infoWall.collider.gameObject.layer == 10)
            //{
            //    infoWall = null;
            //}
        }
        else
        {
             infoWall = Physics2D.Raycast(wallController.position, Vector2.left, wallDistance);

        }
       

        if (infoWall == true) //Y si choca con algo que lleva el layer "Wall"
        {
           
            Rotate();
        }

    }

}
