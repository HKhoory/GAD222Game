using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private float speed;

    private float hMovement;
    //private float vMovement;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //movemeent mechanic
        hMovement = Input.GetAxisRaw("Horizontal");
        //vMovement = Input.GetAxisRaw("Vertical");

        Quaternion turning = Quaternion.Euler(0f, hMovement * speed * Time.deltaTime, 0f);

        _rb.MoveRotation(_rb.rotation * turning);



        //if mouse position is at left or right of screen,
        //turn that way

    }

}
