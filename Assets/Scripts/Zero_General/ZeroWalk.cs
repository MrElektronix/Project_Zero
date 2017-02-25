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

    [HideInInspector] public bool MovingToObject;
    [HideInInspector] public bool Active;


	private void Start ()
	{
	    _walkingSpeed = 5f;
	    _zeroMain = GetComponent<ZeroMain>();
	    MovingToObject = false;
	    Active = false;
	}
	

	private void Update ()
	{
	    if (MovingToObject)
	    {
	        //Debug.Log("Hey, im walking here !");
	        _zeroMain.GoToObject.Player.transform.position = Vector3.MoveTowards(_zeroMain.GoToObject.Player.transform.position, _zeroMain.GoToObject.Other.transform.position,
	            _walkingSpeed * Time.deltaTime);
	        Active = true;
	    }
	    else
	    {
	        //Debug.Log("Iswalking: " + MovingToObject);
	        var x = Input.GetAxisRaw("Horizontal") * _walkingSpeed;
	        var z = Input.GetAxisRaw("Vertical") * _walkingSpeed;

	        _rigidbody.velocity = new Vector3(x, _rigidbody.velocity.y, z);
	    }
	}
}
