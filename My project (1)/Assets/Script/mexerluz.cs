using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mexerluz : MonoBehaviour
{
    Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction * Time.deltaTime);

        if (transform.position.x <= -2.25)
        {
            direction = Vector3.back;
            transform.Translate(direction * Time.deltaTime);
        }
        if (transform.position.z <= 1)
        {
            direction = Vector3.right;
            transform.Translate(direction * Time.deltaTime);
        }
        if (transform.position.x >= 2.25)
        {
            direction = Vector3.forward;
            transform.Translate(direction * Time.deltaTime);
        }
        if (transform.position.z >= 4.4)
        {
            direction = Vector3.left;
            transform.Translate(direction * Time.deltaTime);
            {

            }


        }
    }
}
