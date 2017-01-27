using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

    void OnCollisionEnter(Collision Collision)
    {
        GameObject.Find("Sphere").GetComponent<Test>().Testvoid(score);
    }
}
