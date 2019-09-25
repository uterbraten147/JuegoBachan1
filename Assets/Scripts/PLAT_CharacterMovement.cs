using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAT_CharacterMovement : MonoBehaviour
{
    public Animator anim;
    //public PLAT_GroundCheck groundCheck;
    public float speed = 10;
    public float jumpForce = 20;
    public float gravityScale = 1;
    public float jumpDelay = 0.1f;

    public Transform playerTarget;

    private Camera cam;
    private CharacterController controller;
    private Vector3 moveDirection;
    private Vector3 camR;
    private Vector3 camF;
    private float verticalAxis; // "Stick_Left_Y"
    private float horizontalAxis; // "Stick_Left_X"
    private float animRun;
    private float timePassed;
    private float timeToJump;
    private GameObject matChanger;

    void Start()
    {
        cam = Camera.main;
        controller = GetComponent<CharacterController>();
        matChanger = GameObject.Find("GameManager");//puede ser otro nombre
        //this.transform.GetChild(0).transform.GetChild(1).GetComponent<Renderer>().material = matChanger.GetComponent<PLAT_Material>().finalMat;
    }

    void Update()
    {
        verticalAxis = Input.GetAxis("Stick_Left_Y");
        horizontalAxis = Input.GetAxis("Stick_Left_X");

        camR = new Vector3(cam.transform.right.x, 0, cam.transform.right.z);
        camF = new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z);

        moveDirection = new Vector3(0, moveDirection.y, 0);
        moveDirection +=  ((speed * horizontalAxis * camR) + (speed * verticalAxis * camF)); // Usamos los inputs y las direcciones de la camara para mover al jugador

        if (Mathf.Abs(horizontalAxis) > 0.1 || Mathf.Abs(verticalAxis) > 0.1) // Actualizamos la direccion del jugador
        {
            transform.LookAt(new Vector3(moveDirection.x * 100, transform.position.y, moveDirection.z * 100));
        }  

        if (Input.GetButtonDown("Button_A") && controller.isGrounded && timeToJump > jumpDelay) // Se checa si el jugador esta tocando el piso para SALTAR.
        {
            moveDirection.y = jumpForce;
            timePassed = 0.1f;
        }

        if (controller.isGrounded)
        {
            anim.SetBool("FallingBool", false);

            if (timeToJump < 100)
            {
                timeToJump += Time.deltaTime;
            }

            timePassed = 0;
        }
        else
        {
            timeToJump = 0;
            anim.SetBool("FallingBool", true);
            timePassed += Time.deltaTime;
        }
        anim.SetFloat("FallFloat", timePassed);

        animRun = new Vector3(moveDirection.x, 0, moveDirection.z).magnitude;
        anim.SetFloat("RunFloat", animRun); // Le pasamos el valor del movimiento al animator para que sepa que animacion usar.
        moveDirection.y += Physics.gravity.y * gravityScale * Time.deltaTime; // Simulamos la gravedad y le informamos al character controller
        controller.Move(moveDirection * Time.deltaTime); // Movemos el character controller
    }

    public void setMoveY(float fuerzalto)
    {
        moveDirection.y = fuerzalto;
    }


}
