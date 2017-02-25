using UnityEngine;
/// <summary>
/// Walking of Zero.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class ZeroWalk : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;
    [HideInInspector] private ZeroMain _zeroMain;
    private float _walkingSpeed;


	private void Start ()
	{
	    _walkingSpeed = 5f;
	    _zeroMain = GetComponent<ZeroMain>();
	}
	

	private void Update ()
	{
        //Debug.Log("Hey, im walking here !");
        _zeroMain.GoToObject.Player.transform.position = Vector3.MoveTowards(_zeroMain.GoToObject.Player.transform.position, _zeroMain.GoToObject.Other.transform.position,
            _walkingSpeed * Time.deltaTime);


	}
}
