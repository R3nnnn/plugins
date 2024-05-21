using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAIPatrol : MonoBehaviour
{
    GameObject player;

    private AudioSource audioController;
    public AudioClip background;
    public AudioClip NewSong;

    ChangeCamera camaraEffects;
    bool detected;

    NavMeshAgent agent;
    

    [SerializeField] LayerMask groundLayer, playerLayer;

    private Vector3 spawnActual;

    public Vector3[] possiblePositions = new Vector3[]
    {
    };

    public string estado;

    //patrullaje
    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    //state change
    [SerializeField] float sightRange, attackRange;
    bool playerInSight, playerInAttackRange;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        audioController = GetComponent<AudioSource>();
        int indice = UnityEngine.Random.Range(0, possiblePositions.Length);
        spawnActual = possiblePositions[indice];
        transform.position = spawnActual;
        camaraEffects = GetComponent<ChangeCamera>();
        detected = false;
        camaraEffects.Deactivate();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerInSight && !playerInAttackRange) Patrol();
        if (playerInSight && !playerInAttackRange) Persecucion();
        if (playerInSight && playerInAttackRange) Ataque();

    }

    private void FixedUpdate()
    {
        playerInSight = Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.forward, transform.rotation, 30f, playerLayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, sightRange, playerLayer);
    }

    void Persecucion()
    {
        _ = agent.SetDestination(player.transform.position);
        agent.speed = 55f;
        estado = "Persecucion";
        StartCoroutine(CorutinaMusica());
    }

    IEnumerator CorutinaMusica()
    {
        while (true)
        {
            if (playerInSight && !playerInAttackRange)
            {
                ChangeMusic(NewSong);
                camaraEffects.Activate();
            }
            else
            {
                camaraEffects.Deactivate();
                ChangeMusic(background);
            }
            yield return null;
        }
    }

    public void ChangeMusic(AudioClip newClip)
    {
        if (audioController.clip != newClip)
        {
            audioController.Stop();
            audioController.clip = newClip;
            audioController.Play();
        }
    }

    void Ataque()
    {
        estado = "Ataque";
    }
    void Patrol()
    {
        agent.speed = 20f;
        if (!walkpointSet) SearchForDest();
        if (walkpointSet) agent.SetDestination(destPoint);
        if (Vector3.Distance(transform.position, destPoint) < 10) walkpointSet = false;
        estado = "patrol";
    }

    void SearchForDest()
    {
        float z = UnityEngine.Random.Range(-range, range);
        float x = UnityEngine.Random.Range(-range, range);

        destPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer))
        {
            walkpointSet = true;
        }
    }

    private void OnDestroy()
    {
        if (camaraEffects != null)
        {
            camaraEffects.Deactivate();

        }
    }
}
