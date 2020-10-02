﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public int score;

    public DisplayManager RefDisplayerManager;
    private Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);

    public float MassProperty
    {
        get
        {
            var parameter = 1 / Mathf.InverseLerp(0f, 10000f, score + 10);
            return parameter;
        }
    }

    void Start()
    {
        if (RefDisplayerManager == null)
        {
            RefDisplayerManager = GetComponentInParent<DisplayManager>();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            gameObject.transform.localScale += scaleChange;
            score += 1;
            Destroy(other.gameObject);
            RefDisplayerManager.CurrentScoreText.text = score.ToString();
        }
    }
}