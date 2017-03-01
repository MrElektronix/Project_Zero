using System.Collections;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Walking of Zero.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class ZeroWalk : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;
    [HideInInspector] private ZeroMain _zeroMain;
    [SerializeField] private NavMeshAgent _agent;
    private float _timer;
    private float _cooldowntime;
    private float _walkingSpeed;
    [HideInInspector] public bool IsWalking;


	private void Start ()
	{
	    _walkingSpeed = 5f;
	    _zeroMain = GetComponent<ZeroMain>();
	    _cooldowntime = 5f;
	}



	private void Update ()
	{



	    if (IsWalking)
	    {
	        if (_timer < Time.time)
	        {
	            _timer = Time.time + _cooldowntime;
	            var x = Random.Range(-7, 7);
	            var z = Random.Range(-7, 7);
	            _agent.SetDestination(new Vector3(x, 1.2f, z));
	            _zeroMain.ZeroEnergy.Energy -= 50;
	        }
	    }

	    if (!IsWalking)
	    {
	        return;
	    }

	}
}
