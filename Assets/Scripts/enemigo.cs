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

    public void TomarDano(float dano)
    {
        vida -= dano;

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
