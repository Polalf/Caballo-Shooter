using UnityEngine;

public class train : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float speed;
    [SerializeField] int life;
    float currentSpeed;
    bool canCheck;

    [Header("Objetos")]

    public GameObject[] vagones;
    bool canMove;

    [Header("Movimiento")]
    public Transform puntoA;
    public Transform puntoB;

    void Update()
    {
        bool canDie = false;
        if(canCheck)
        {
            
            if (life <= 0)
            {
                canDie = true;
            }
        }
        if (canDie)
        {
            canDie = false;
            DetenerTren();
            
        }

        if(canMove)
        {
            transform.position += new Vector3(0, currentSpeed) * Time.deltaTime;
            if (transform.position.y >= puntoA.transform.position.y)
            {
                canMove = false;
                Atacar();
            }
        }
       
            

    }
    public void Activar()
    {
        canMove = true;
        life = 100;
        currentSpeed = speed;
        canCheck = true;
        
       
    }
    void Atacar()
    {
        int i = 0;
        while(i < vagones.Length)
        {
            vagones[i].GetComponent<vagon>().ActivarVagon();
            i++;
        }
    }
    public void DetenerTren()
    {
        int i = 0;
        currentSpeed = speed * -1;
        canMove = true;
        
        if (transform.position.y <= puntoB.transform.position.y)
        {
            canMove = false;
            canCheck = false;
            while (i < vagones.Length)
            {
                vagones[i].GetComponent<vagon>().DesactivarVagon();
                i++;
                gameObject.GetComponentInParent<invocadorEnemigos>().ActivarRutinaTren();
            }
        }
    }
}
