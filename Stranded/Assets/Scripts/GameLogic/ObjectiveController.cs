﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveController : MonoBehaviour
{
    public GameObject ObjectiveTextObject;
    Animator animator;
    Text ObjectiveText;
    void Awake()
    {
        animator = GetComponent<Animator>();
        ObjectiveText = ObjectiveTextObject.GetComponent<Text>();

        // Set Objective Description text
        SetObjective("No Objectives");
    }

    void Update() {
        if(Input.GetButtonDown("Objective") || Input.GetAxis("Objective") > 0.5) {
            ShowObjectivePanel();
        }
        if(Input.GetButtonUp("Objective") || Input.GetAxis("Objective") < 0.5) {
            HideObjectivePanel();
        }
    }

    void HideObjectivePanel() {
        animator.SetBool("IsVisible", false);
    }

    void ShowObjectivePanel() {
        animator.SetBool("IsVisible", true);
    }

    // Set Objective Text
    public void SetObjective(string text) {
        ObjectiveText.text = text;
    }
}
