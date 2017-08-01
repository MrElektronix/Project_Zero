using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Walking of Zero.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class Walk : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private NavMeshAgent _agent;

    [HideInInspector] private ClassControl _classControl;
    [HideInInspector] public bool IsWalking;

    private float _timer;
    private float _cooldowntime;
    private float _walkingSpeedY;



	private void Start ()
	{
	    _classControl = GetComponent<ClassControl>();

	    _walkingSpeedY = 1.2f;
	    _cooldowntime = 5f;
	}


	private void Update ()
	{
	    if (!IsWalking)
	    {
	        return;
	    }

	    if (_timer < Time.time)
        {
            _timer = Time.time + _cooldowntime;
            WalkRandomDirection();
            _classControl.Energy.TotalEnergy -= 50;
        }
	}


    private void WalkRandomDirection()
    {
        var x = Random.Range(-7, 7);
        var z = Random.Range(-7, 7);
        _agent.SetDestination(new Vector3(x, _walkingSpeedY, z));
    }
}
