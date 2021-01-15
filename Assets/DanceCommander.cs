using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceCommander : MonoBehaviour
{

    [SerializeField] GameObject tree;
    [SerializeField] GameObject santa;
    [SerializeField] Material myMaterial;
    Animator santaAnimator;
    
    
    void Start()
    {
        santaAnimator = santa.GetComponent<Animator>();
    }

    
    void Update()
    {
        float dist = Vector3.Distance(tree.transform.position, santa.transform.position);
        if(dist < 0.35)
        {
            myMaterial.color = Color.yellow;
            santaAnimator.SetBool("isDancing", true);
        }
        else
        {
            myMaterial.color = Color.red;
            santaAnimator.SetBool("isDancing", false);
        }
    }
}
