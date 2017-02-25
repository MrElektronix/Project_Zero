using UnityEngine;

public class GoToObject : MonoBehaviour
{
    public Transform Other;
    public GameObject Player;
    [HideInInspector] private ZeroMain _zeroMain;
    private float _distance;


    private void Start()
    {
        _zeroMain = GetComponent<ZeroMain>();
    }

    private void Update()
    {
        _distance = Vector3.Distance(Player.transform.position, Other.transform.position);
        //Debug.Log("Distance: " + _distance);
        if (_distance >= 2 && _distance <= 6 && _zeroMain.ZeroWalk.MovingToObject == false)
        {
            _zeroMain.ZeroWalk.MovingToObject = true;
        }
        else
        {
            _zeroMain.ZeroWalk.MovingToObject = false;
        }
    }

}
