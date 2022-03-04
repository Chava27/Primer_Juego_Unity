/*
Basic motion affecting the transform of an object
Salvador Salgado Normandia A014228874
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMotion : MonoBehaviour
{
    //Define velocity
    [SerializeField]float speed = 0.25f;
    //Vector3 (position x,y,z)
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        
    }

    // Update is called once per frame
    void Update()
    {
        //Read the input from the keyboard or gamepad
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        //Apply the new data to the object transform
        transform.Translate(move *speed * Time.deltaTime);
        if(transform.position.x>4.85){
            Vector3 pos= transform.position;
            pos.x=4.85f;
            transform.position=pos;
        }
        if(transform.position.x<-1.5){
            Vector3 pos= transform.position;
            pos.x=-1.5f;
            transform.position=pos;
        }
        if(transform.position.y<-18.5){
            Vector3 pos= transform.position;
            pos.y=-18.5f;
            transform.position=pos;
        }
        if(transform.position.y>34){
            PlayerManager.gameOver=true;
        }
    }
    public void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag=="asteroid"){
            PlayerManager.gameOver=true;
        }
        if(col.gameObject.tag=="finish"){
            PlayerManager.gameOver=true;
        }
    }

}
