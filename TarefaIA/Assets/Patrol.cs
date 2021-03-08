using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public List<Transform> Goals = new List<Transform>();
    Transform LastPoint;
    int goal = 0;
    bool retun;
    // Start is called before the first frame update
    void Start()
    {
        LastPoint = Goals[goal];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, LastPoint.position) > 0.2f)
            transform.position += (LastPoint.position - transform.position).normalized * 8f * Time.deltaTime;
        else
            ChangePatrolPoint();
    }
    void ChangePatrolPoint()
    {
        if (!retun)
            goal++;
        else
            goal--;

        if (goal >= Goals.Count)
        {
            goal = (Goals.Count - 1);
            retun = true;
        }
        else if (goal < 0)
        {
            goal = 0;
            retun = false;
        }

        LastPoint = Goals[goal];
    }
}
