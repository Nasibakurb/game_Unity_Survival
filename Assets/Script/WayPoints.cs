﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {
    public GameObject[] waypoints; // масив
    public int num = 0;
    public float minDist;
    public float speed;
    public bool rand = false;
    public bool go = true;
    private Transform target; // цель
    void Start() {
      
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);
        if (go)
        {
            if (dist > minDist)
            {
                move();
            }
            else
            {
                if (!rand)
                {
                    if (num + 1 == waypoints.Length)
                    {
                        num = 0;
                    }
                    else { num++; }
                }
                else { num = Random.Range(0, waypoints.Length); }
            }
        }
    }

    public void move()
    {
    gameObject.GetComponent<Animator>().SetTrigger("Move");   // AI двигается аниматор
    gameObject.transform.LookAt(waypoints[num].transform.position);
    gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
}
