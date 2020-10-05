using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] points;
    void Start()
    {
        GameObject wayPointGroup = GameObject.Find("WayPointGroup");
        if(wayPointGroup != null)
        {
            points = wayPointGroup.GetComponentInChildren<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
