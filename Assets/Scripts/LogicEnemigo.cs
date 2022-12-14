using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicEnemigo : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    private Animator ani;
    public Quaternion angulo;
    public float grado;
    public int distancia;

    public GameObject target;
    public bool atacando;
    public RangoEnemigo rango;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        //target = GameObject.Find("Jugador");
        target = GameObject.Find("Player");
    }

    public void comportamientoEnemigo()
    {
        if(Vector3.Distance(transform.position, target.transform.position) > distancia)
        {
            ani.SetBool("run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("walk", false);
                    break;
                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    ani.SetBool("walk", true);
                    break;
            }
        }
        else
        {
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
            { 
                
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);

                ani.SetBool("walk", false);
                ani.SetBool("run", true);

                transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                ani.SetBool("attack", false);
            }
            else
            {
                ani.SetBool("walk", false);
                ani.SetBool("run", false);
                ani.SetBool("attack", true);
                atacando = true;
            }
        }
    }

    public void fianlAni()
    {
        ani.SetBool("attack", false);
        atacando = false;
        rango.GetComponent<CapsuleCollider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        comportamientoEnemigo();
    }
}