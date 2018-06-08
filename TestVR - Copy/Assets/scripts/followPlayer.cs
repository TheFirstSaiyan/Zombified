using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followPlayer : MonoBehaviour {


    private NavMeshAgent nav;
    private GameObject player;
   public Animator animator;
    private float t=0;

	void Start () {
        player = GameObject.Find("player");
        nav = GetComponent<NavMeshAgent>();
        nav.speed = Random.Range(1f, 3f);

        nav.acceleration = Random.Range(1f, 10f);
        
       
    }
	
	void Update () {
        t += Time.deltaTime;
        if(t>2.5f)
        nav.destination = player.transform.position;
        if (Vector3.Distance(transform.position, player.transform.position) <= 5f)
         {
             animator.SetTrigger("EnemyNear");
        }
        else
            animator.SetTrigger("EnemyAway");



      
    }
}
