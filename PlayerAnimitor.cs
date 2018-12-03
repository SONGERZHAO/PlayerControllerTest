using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimitor : MonoBehaviour
{
    private CharacterController cc;
    private Animator anim;
    private GameData gamedata2;
    private float sleeptime;

    public bool flag;
    public float speed = 4;
    public Text mark;

    void Start()
    {
        cc = this.GetComponent<CharacterController>();
        anim = this.GetComponent<Animator>();
        GameObject gamedata = GameObject.Find("GameData");
        gamedata2 = gamedata.GetComponent<GameData>();
        gamedata2.count = 0;
        flag = false;
        sleeptime = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
           // Debug.Log(hit.point);
            Vector3 target = hit.point;
            target.y = transform.position.y;
            transform.LookAt(target);

        }
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("test", true);
        }
        else
        {
            anim.SetBool("test", false);
        }

        if (Input.GetMouseButton(1))
        {
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("attack", false);
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1f)
            {
                anim.SetInteger("h_v", 1);
                Vector3 targetDir = new Vector3(h, 0, v);
                transform.LookAt(targetDir + transform.position);
                cc.SimpleMove(transform.forward * speed);
            }
            else
            {
                anim.SetInteger("h_v", 0);
            }
        }

        mark.text = "ATTACK:" + gamedata2.count.ToString();

    }

}