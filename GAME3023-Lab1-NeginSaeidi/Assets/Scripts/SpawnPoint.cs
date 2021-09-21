using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    GameObject playerPrefab;

    static PlayerBehaviour playerReference = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerReference)
		{
            GameObject newPlayerObject =  Instantiate(playerPrefab, transform.position, transform.rotation);
            playerReference = newPlayerObject.GetComponent<PlayerBehaviour>();
		}
    }
}
