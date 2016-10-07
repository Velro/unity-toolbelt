using UnityEngine;
using System.Collections;

public class DelayedDestroy : MonoBehaviour
{

    public float liveDuration = 1;

    
    void Start ()
    {
        Destroy(gameObject, liveDuration);
	}
	
}
