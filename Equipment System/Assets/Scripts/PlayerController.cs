using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController cc;
    public Transform cam;

    public float walkSpeed;

    private float horizontal;
    private float vertical;

    private float turnTime = 0.1f;
    private float turnVelocity;

    private void Start()
    {
        cc = GetComponent<CharacterController>(); 
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targerAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targerAngle, ref turnVelocity, turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targerAngle, 0f) * Vector3.forward;
            cc.Move(moveDir.normalized * walkSpeed * Time.deltaTime);
        }
    }
}
