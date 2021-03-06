﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    [SerializeField] private Vector3 _newPosition;
    [SerializeField] public float magnitude;
    [SerializeField] private float speedx;
    [SerializeField] private float speedy;

    void Start()
    {
        speedx = Random.Range(1f, 2f);
        magnitude = Random.Range(-500f, 500f);
        speedy = Random.Range(10f, 100f);
    }

    void Update()
    {
        _newPosition = transform.position;
        _newPosition.x += (Mathf.Cos(Time.time) * Time.deltaTime * speedx) * magnitude;
        _newPosition.y -= Time.deltaTime * speedy;
        transform.position = _newPosition;

        //If command falls off screen then delete the command.
        if(gameObject.GetComponent<RectTransform>().localPosition.y < -650)
        {
            Destroy(this.gameObject);
        }
    }
}
