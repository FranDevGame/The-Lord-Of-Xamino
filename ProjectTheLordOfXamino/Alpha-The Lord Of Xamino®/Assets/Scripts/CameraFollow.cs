using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //variable para declarar al objetivo (target) que seguir� la c�mara.

    public Vector3 offset = new Vector3(-3f, 0f, -10f); /*Variable para declarar a la distancia 
                                                          * que la c�mara debe seguir al personaje.*/

    public float dampingTime = 0.3f; /*Variable para amortiguar el avance de la c�mara, 
                                      * para que sea relajado y no tan brusco a la vista.*/

    public Vector3 velocity = Vector3.zero;

    [SerializeField] float leftLimite;

    [SerializeField] float rightLimit;

    [SerializeField] float bottomLimit;

    [SerializeField] float topLimit;

    // Update is called once per frame
    void Update()
    {
        MoveCamera(true); //Aqu� el m�todo MoveCamera con par�metro booleano ser� true ya que queremos suavidad de la c�mara durante la partida.

        //transform.position = new Vector3
        //(
        //   Mathf.Clamp(transform.position.x, leftLimite, rightLimit),
        //   Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
        //   transform.position.z
        //);
    }

    public void ResetCameraPosition() /*M�todo para resetear la c�mara, para cuando el personaje muera,
                                       * no lo siga hasta los confines del mundo. Y vuelva a la LevelStartPosition*/
    {
        MoveCamera(false); // En el reseteo de la c�mara el MoveCamera estar� en false para que sea instant�neo.
    }

    void MoveCamera(bool smooth)/*Con el m�todo MoveCamera a�adimos una funcionalidad al DampingTime,
                                 * y es que cuando se vaya moviendo la c�mara estar� en "true"
                                 * y cuando el personaje muera, estar� en false. De manera que, al morir
                                 * no har� un barrido hacia atr�s, si no que ser� instant�neo. 
                                 * en un frame, estar� en la pantalla de muerte, y en el siguiente,
                                 * estar� en la posici�n inicial para comenzar de nuevo la partida.(false)*/

    {
        Vector3 destination = new Vector3 /*Declaramos una variable Vector3 con el nombre destination
                                           * que ser� el destino de la c�mara, que en este caso ser�
                                           * la posici�n del objetivo (target.position.x) 
                                           * menos la variable de la distancia(offset.x)
                                           * Y luego declarar las distancias de los ejes Y y Z.*/

            (target.position.x - offset.x, offset.y, offset.z);

        /*No se puede asginar directamente "this.transform.position" a "MoveCamera"
        * es decir, "esta configuraci�n de transform con esta posici�n" al m�todo
        * MoveCamera; ya que tenemos un m�todo con par�metros booleanos. 
        * As� que declaramos un If donde sentenciamos distinos par�metros para 
        * que se cumplan en condici�n "true".*/

        if (smooth == true)
        {
            this.transform.position = Vector3.SmoothDamp(this.transform.position, destination, ref velocity, dampingTime);

            /*La variable velocity la vamos a pasar por referencia (ref), 
             * de modo que va desde nuestro Script en VS,
             * al Script de Unity para que �ste haga sus c�lculos y
             * nos la devuelva al Script de VS para ver la velocidad de la
             * c�mara sin tener que calcularlo yo. Lo har� en m�todo SmoothDamp.*/

        }
        else
        {
            this.transform.position = destination; /*Aqu� asignamos directamente this.transform.position
                                                    *a destination de la c�mara ya que estar� en false,
                                                    *para cuando muera el personaje y no necesitamos 
                                                    *el deslizar suave de la c�mara.*/

        }
    }

    //public void OnDrawGizmos()
    //{
    //    //Dibujaremos los bounds de la c�mara

    //    Gizmos.color = Color.magenta;
    //    //Top bound line
    //    Gizmos.DrawLine(new Vector2(leftLimite, topLimit), new Vector2(rightLimit, topLimit));
    //    //right bound line
    //    Gizmos.DrawLine(new Vector2(rightLimit, topLimit), new Vector2(rightLimit, bottomLimit));
    //    //bottom bound line
    //    Gizmos.DrawLine(new Vector2(rightLimit, bottomLimit), new Vector2(leftLimite, bottomLimit));
    //    //left bound line
    //    Gizmos.DrawLine(new Vector2(leftLimite, bottomLimit), new Vector2(leftLimite, topLimit));

    //}
}
