﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator m_Animator;

    public bool normalIsMoving;
    bool m_IsMoving;

    // Start is called before the first frame update
    void Start()
    {
        
        m_Animator = gameObject.GetComponent<Animator>();
        m_IsMoving = false;
        m_Animator.SetFloat("Rando",Random.Range(0.0f,1f));
        m_Animator.Play(0, -1, Random.value);
    }

    // Update is called once per frame
    void Update()
    {
        if (normalIsMoving)
        {
            m_Animator.SetBool("IsMoving", true);
        }
        else
        {
            m_Animator.SetBool("IsMoving", false);
        }
    }
}