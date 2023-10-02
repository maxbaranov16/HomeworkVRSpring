using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float Speed = 7f;
    public GameObject roll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {


            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {


            transform.Rotate(Vector3.down * 5*Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {


            transform.Translate(Vector3.back *  Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {


            transform.Rotate(Vector3.up *5* Speed * Time.deltaTime);
        }
    }
    private void OnMouseEnter()
    {
        roll.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnMouseExit()
    {
        roll.gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
