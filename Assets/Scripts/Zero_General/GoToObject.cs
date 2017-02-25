using UnityEngine;

public class GoToObject : MonoBehaviour
{
    public Transform Other;
    public GameObject Player;
    [HideInInspector] private ZeroMain _zeroMain;
    [HideInInspector] public float DistanceToObject;


    private void Start()
    {
        _zeroMain = GetComponent<ZeroMain>();
    }

    private void Update()
    {
        DistanceToObject = Vector3.Distance(Player.transform.position, Other.transform.position);
        Debug.Log("Distance: " + DistanceToObject);
       
    }

}
