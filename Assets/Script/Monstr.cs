using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Monstr : MonoBehaviour
{
    public float seeDistance = 5f;
    public float attackDistance = 2f;
    public float speed;
    private Transform target; //цель
    public int healthMonster;
    public Slider slider; //hp bar 
    public GameObject bloodyScreen;
   

    [SerializeField]
    private GameObject AI;
    WayPoints controller;

    private AudioSource source;

    void Start()
    {
        controller = AI.GetComponent<WayPoints>();
        target = GameObject.FindWithTag("Player").transform; //прислед
        source = GetComponent<AudioSource>();


    }

    void Update()
    {
        slider.value = healthMonster;

        if (healthMonster <= 0)
        {
            Destroy(this.gameObject);
     
        }
        if (target == true)
        {
            if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
            {

                if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
                {
                    controller.enabled = false; //ВайПоинтс
                    //движ
                    transform.LookAt(target.transform);
                    transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                    gameObject.GetComponent<Animator>().SetTrigger("Move");
                    bloodyScreen.SetActive(true);
                }
                else
                {
                }
                if (speed != 0.0f || speed != 0.0f)
                {
                    if (!source.isPlaying)
                    {
                        source.Play();
                    }
                }
            }
            else { bloodyScreen.SetActive(false);
                controller.enabled = true;
            }
        }
        else { }

        
    }
}
