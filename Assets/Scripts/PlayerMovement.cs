using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private float speed;
    [SerializeField] private float speed2;

    private float hMovement;
    private float vMovement;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        Vector3 front = transform.TransformDirection(Vector3.forward);
        //movemeent mechanic
        hMovement = Input.GetAxisRaw("Horizontal");
        vMovement = Input.GetAxisRaw("Vertical");

        Quaternion turning = Quaternion.Euler(0f, hMovement * speed * Time.deltaTime, 0f);

        _rb.MoveRotation(_rb.rotation * turning);
        _rb.AddForce(front * speed2 * vMovement, ForceMode.Force);



        //if mouse position is at left or right of screen,
        //turn that way

    }

}
