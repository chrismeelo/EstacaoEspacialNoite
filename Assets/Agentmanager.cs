using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agentmanager : MonoBehaviour
{
    GameObject[] agentes; // Criação do array dos agentes

    // Start is called before the first frame update
    void Start()
    {
        agentes = GameObject.FindGameObjectsWithTag("Ai"); // Procura os agentes na cena 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Se o botão do mouse for apertado 
        {
            RaycastHit hit; // Se houver o contato

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) // Se a linha do raycast tiver fora de colisão executa o foreach
            {
                foreach (GameObject a in agentes) 
                    a.GetComponent<AIcontrol>().agent.SetDestination(hit.point); // Seta novo destino para outro ponto do mouse
            }


        }



    }
}
