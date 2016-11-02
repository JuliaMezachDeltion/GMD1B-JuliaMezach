using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bumper : MonoBehaviour {

    public Rigidbody bal;

    void OnCollisionEnter(Collision Collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().score += 10;
    }
}
