using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{
    public NavMeshAgent zombie;
    public Transform player;
    public LayerMask groundMask, playerMask;
    public Animator zombieAnimation;
    public static bool zombieShouldMove;
    public AudioSource backgroundMusic;

    private void Awake()
    {
        player = GameObject.Find("PlayerBody").transform;
        zombie = GetComponent<NavMeshAgent>();
        zombieAnimation = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!GameMode.gameLost) ChasePlayer();

        else if (GameMode.gameLost)
        {
            zombie.SetDestination(transform.position);
            AnimationHandler();
            backgroundMusic.volume = 0.3f;
        }
    }

    private void ChasePlayer()
    {
        zombie.SetDestination(player.position);
    }

    private void AnimationHandler()
    {
        if (zombieShouldMove == false)
        {
            zombieAnimation.enabled = false;
        }

        else if (zombieShouldMove == true)
        {
            zombieAnimation.enabled = true;
        }
    }
}
