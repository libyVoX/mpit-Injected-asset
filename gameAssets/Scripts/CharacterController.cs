using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float horiz = 0;
    public bool isGround = true;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        transform.Translate(0,0,1 * horiz * Time.deltaTime * 6f);
        if(Input.GetKeyDown(KeyCode.Space) && isGround){
            rb.drag = 2;
            rb.AddForce(0,80f,0,ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "ground"){
            isGround = true;
        }
    } 
    void OnCollisionExit(Collision coll){
        if(coll.gameObject.tag == "ground"){
            rb.drag = 0;
            isGround = false;
        }
    }
}
