using UnityEngine;

public class ZeroMain : MonoBehaviour
{

    [HideInInspector] public ZeroEnergy ZeroEnergy;
    [HideInInspector] public CalculateDistance CalculateDistance;
    [HideInInspector] public ZeroWalk ZeroWalk;
    [HideInInspector] public FoodSpawner FoodSpawner;

	private void Awake ()
	{
	    ZeroEnergy = GetComponent<ZeroEnergy>();
	    CalculateDistance = GetComponent<CalculateDistance>();
	    ZeroWalk = GetComponent<ZeroWalk>();
	    FoodSpawner = GetComponent<FoodSpawner>();
	}

}
