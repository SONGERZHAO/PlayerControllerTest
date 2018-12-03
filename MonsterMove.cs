using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterMove : MonoBehaviour {


    private GameObject player;
    private NavMeshAgent agent;
    private Animator anim;
    private AnimatorStateInfo animinfor;
    private bool flag;

    public bool Gethit;
    public bool Attack;
    public GameObject die;


    void Start ()
    {
        player = GameObject.Find("Player");
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        die.SetActive(false);        
        flag = true;
        Gethit = false;
        Attack = false;
    }
	
	void Update () {

        animinfor = anim.GetCurrentAnimatorStateInfo(0);
        if (flag)
        {
            agent.SetDestination(player.transform.position);
        }

        if ((Gethit)&&(flag))
        {
            
            anim.SetInteger("Controller", -1);
            animinfor = anim.GetCurrentAnimatorStateInfo(0);
            flag = false;
            Gethit = false;
        }
        else if(!flag && !Gethit)
        {
            if ((animinfor.normalizedTime >= 1.0f) && animinfor.IsName("Get Hit"))
            {
                anim.SetInteger("Controller", 0);
                agent.SetDestination(player.transform.position);
                flag = true;
            }
        }

        if ((Attack) && (flag))
        {
            anim.SetInteger("Controller", 1);
            die.SetActive(true);
            animinfor = anim.GetCurrentAnimatorStateInfo(0);
            flag = false;
            Attack = false;

        }
        else if (!flag && !Attack)
        {
            if ((animinfor.normalizedTime >= 1.0f) && animinfor.IsName("Attack"))
            {
                anim.SetInteger("Controller", 0);
                agent.SetDestination(player.transform.position);
                flag = true;
                Application.LoadLevel("Charts");
            }
        }
    }
}
