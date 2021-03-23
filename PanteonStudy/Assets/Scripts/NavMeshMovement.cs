using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _destination;
    private NavMeshAgent _navMeshAgent;
    private Animator _animator;
    

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        SetDestination();
        _animator = GetComponent<Animator>();
        _animator.SetBool("isRunning", true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("famn");
        }
    }

    void Update()
    {

        if (!_navMeshAgent.pathPending)
        {
            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance + 1f)
            {
                if (!_navMeshAgent.hasPath || _navMeshAgent.velocity.sqrMagnitude == 0f)
                {
                    _animator.SetBool("isRunning", false);
                    _animator.SetBool("isWon", true);
                    StartCoroutine(AgentFinish());
                }
            }
        }
    }
    IEnumerator AgentFinish()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }

}
