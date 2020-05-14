using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float y_limit = 5;
    private float x_limit = 8;
    



    // Update is called once per frame
    void Update()
    {



        if (transform.position.y > y_limit || transform.position.y < -y_limit || transform.position.x > x_limit || transform.position.x < -x_limit)
        {
            Destroy(gameObject);
        }
    }
}
