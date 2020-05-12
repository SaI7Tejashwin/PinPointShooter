using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    private Rigidbody2D playerRb;
    public Camera cam;

    Vector2 move;
    Vector2 mousePos;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

       

        
    }


    private void FixedUpdate()  //this is used when you desire for smooth physics movement.
    {


        playerRb.MovePosition(playerRb.position + move * speed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePos - playerRb.position;

        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        playerRb.rotation = angle;


    }
}
