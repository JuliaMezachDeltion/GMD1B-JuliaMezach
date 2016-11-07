using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{

    public float power;
    public GameObject prefab;
    public GameObject spawnLocation;
    public bool activeball;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GameObject.Find("GameManager").GetComponent<GameManager>().lives > 0)
            {
                if (activeball == false)
                {
                    SpawnPinball();
                }
            }
            activeball 
        }
    }

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)(Instantiate(prefab, spawnLocation.GetComponent<Transform>().position, spawnLocation.GetComponent<Transform>().rotation));
        pinball.GetComponent<Rigidbody>().velocity = spawnLocation.GetComponent<Transform>().transform.forward * power;
    }

}