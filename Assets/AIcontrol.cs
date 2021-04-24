using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontrol : MonoBehaviour
{
    public NavMeshAgent agent; // Está pegando o componente agent
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>(); // Pegando as propriedades para poder dodifica-las
    }

    
}
