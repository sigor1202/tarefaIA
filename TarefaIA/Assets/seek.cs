using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek : MonoBehaviour
{
    public Transform alvo;
    public float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (alvo.position - transform.position).normalized*speed*Time.deltaTime;
    }
}
