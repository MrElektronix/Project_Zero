using UnityEngine;

public class ZeroMain : MonoBehaviour
{

    [HideInInspector] public ZeroEnergy ZeroEnergy;
    [HideInInspector] public GoToObject GoToObject;
    [HideInInspector] public ZeroWalk ZeroWalk;

	private void Awake ()
	{
	    ZeroEnergy = GetComponent<ZeroEnergy>();
	    GoToObject = GetComponent<GoToObject>();
	    ZeroWalk = GetComponent<ZeroWalk>();
	}

}
