using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private Vector3 follow;
    public Transform birdTransform;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        birdTransform = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isDead)
            return;
        follow.x = 1;
        follow.y = 1;
        follow.z = -10;
        transform.position = birdTransform.position + follow;

    }
   
    
}
