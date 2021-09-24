using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
        WorldsTraveler worldTravellerObject = otherCollider.GetComponent<WorldsTraveler>();
		if(worldTravellerObject != null)
		{
			Debug.Log("Traveling to " + tag);
            SceneManager.LoadScene(tag);
		}
	}
}
