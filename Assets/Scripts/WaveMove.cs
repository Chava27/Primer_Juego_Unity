using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove : MonoBehaviour
{
    [SerializeField] Vector3 move;
    [SerializeField] AudioClip noice;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(move*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col){
        move=-move;
        
    }
}
