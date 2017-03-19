using UnityEngine;

public class ClassControl : MonoBehaviour
{

    [HideInInspector] public Energy Energy;
    [HideInInspector] public CalculateDistance CalculateDistance;
    [HideInInspector] public Walk Walk;
    [HideInInspector] public FoodSpawner FoodSpawner;

	private void Awake ()
	{
	    Energy = GetComponent<Energy>();
	    CalculateDistance = GetComponent<CalculateDistance>();
	    Walk = GetComponent<Walk>();
	    FoodSpawner = GetComponent<FoodSpawner>();
	}

}
