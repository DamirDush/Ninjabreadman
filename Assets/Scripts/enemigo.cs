using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    [SerializeField] private float vida;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();    
    }

    public void TomarDa�o(float da�o)
    {
        vida -= da�o;

        if(vida <= 0)
        {
            Muerte();
        }

    }

    private void Muerte()
    {
        Destroy(gameObject, 0.5f);
    }

}
