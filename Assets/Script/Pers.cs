using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pers : MonoBehaviour
{
    public float speed ;
    public float sensitivty = 10f; //чувства 
    CharacterController player;
    public GameObject eyes;         // мышь
    private float moveFB, moveLR, rotX, rotY, vertVelocty;
    public float jumpForce = 4f;
    private bool hasJumped, isCrouched;
    private AudioSource source;

    void Start()
    {
        player = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        //пжок 
        Movement();
        if (Input.GetButtonDown("Jump"))
        {
            hasJumped = true;
        }
        if (Input.GetButtonDown("Crouch")) // пресмыкаться 
        {
            if (isCrouched == false)
            {
                player.height = player.height / 2;
                isCrouched = true;
            }
            else
            {
                player.height = player.height * 2;
                isCrouched = false;
            }
        }
        ApplyGravity();
    }

    public void Movement()
    {
        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;
        rotX = Input.GetAxis("Mouse X") * sensitivty; //повороты, повороты с движем 
        rotY = Input.GetAxis("Mouse Y") * sensitivty;

        Vector3 movement = new Vector3(moveLR, vertVelocty, moveFB);
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(-rotY, 0, 0); // камера стоит ровно
        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);

        //звуки шагов 
        if (moveFB != 0.0f || moveFB != 0.0f)
        { // Палка вниз 
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
        if (moveLR != 0.0f || moveLR != 0.0f)
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
    }

    private void ApplyGravity()
    {
        if (player.isGrounded == true) // заземлен 
        {
            if (hasJumped == false)
            {
                vertVelocty = Physics.gravity.y;
            }
            else
            {
                vertVelocty = jumpForce; //можно прыгать 
            }
        }
        else
        { //скоость приземл 
            vertVelocty += Physics.gravity.y + Time.deltaTime;
            vertVelocty = Mathf.Clamp(vertVelocty, -50f, jumpForce);
            hasJumped = false;
        }

    }
}