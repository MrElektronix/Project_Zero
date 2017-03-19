using UnityEngine;

public class CalculateDistance : MonoBehaviour {

    public Transform Other;
    public GameObject Player;
    [HideInInspector] private ClassControl _classControl;
    [HideInInspector] public float DistanceToObject;


    private void Start()
    {
        _classControl = GetComponent<ClassControl>();
    }

    private void Update()
    {

        DistanceToObject = Vector3.Distance(Player.transform.position, Other.transform.position);
        //Debug.Log("Distance: " + DistanceToObject);

    }
}
