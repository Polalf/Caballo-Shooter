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
    public Transform target;

    //void Start()
    //{
    //    target.position = puntoA.position;
    //    canMove = true;
    //    currentSpeed = speed;
    //}


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
            if (transform.position.y >= target.transform.position.y)
            {
                //currentSpeed = 0;
                Atacar();
                canMove = false;
                
            }
        }
    }
    public void Activar()
    {
        canMove = true;
        life = 100;
        target.position = puntoA.position;
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
        target.position = puntoB.position;
        
        currentSpeed = speed * -1;
        canMove = true;
        
        if (transform.position.y <= target.transform.position.y)
        {
            canMove = false;
            canCheck = false;
            int i = 0;
            while (i < vagones.Length)
            {
                gameObject.GetComponentInParent<invocadorEnemigos>().ActivarRutinaTren();
                vagones[i].GetComponent<vagon>().DesactivarVagon();
                i++;
            }
            
        }
        

    }
}
