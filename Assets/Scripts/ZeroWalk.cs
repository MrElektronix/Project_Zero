using UnityEngine;
/// <summary>
/// Walking of Zero.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class ZeroWalk : MonoBehaviour
{

    [SerializeField] private Rigidbody _rigidbody;
    private float _walkingSpeed;
    private ZeroMain _zeroMain;


	private void Start ()
	{
	    _zeroMain = GetComponent<ZeroMain>();

	}
	

	private void Update ()
	{
	    //Debug.Log(_zeroMain.Walking);
	    if (!_zeroMain.Walking) {_walkingSpeed = 0;}
	    if (_zeroMain.Walking) {_walkingSpeed = 8f;}
	    var x = Input.GetAxisRaw("Horizontal") * _walkingSpeed;
	    var z = Input.GetAxisRaw("Vertical") * _walkingSpeed;

	    _rigidbody.velocity = new Vector3(x, _rigidbody.velocity.y, z);
	}
}
