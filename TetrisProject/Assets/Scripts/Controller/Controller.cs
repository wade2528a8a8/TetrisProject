using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [HideInInspector]
    public Model model;
    [HideInInspector]
    public View view;


    private void Awake()
    {
        model = GameObject.FindGameObjectWithTag(Tags.Model).GetComponent<Model>();
        view = GameObject.FindGameObjectWithTag(Tags.View).GetComponent<View>();



    }


}
