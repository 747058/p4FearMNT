using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject ThePlayer;
    public float PlaceX;
    public float PlaceZ;

    // Start is called before the first frame update
    void Start()
    {
        PlaceX = Random.Range(-24, 26);
        PlaceZ = Random.Range(-1, 29);
        ThePlayer.transform.position = new Vector3(PlaceX, 0, PlaceZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
