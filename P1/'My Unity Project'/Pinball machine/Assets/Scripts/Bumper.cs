using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bumper : MonoBehaviour {

    public Text tekstvakje;
    public static int score;
    public float v;
    public Rigidbody bal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision Collision)
    {
        bal.AddExplosionForce(v , transform.position, 2f);

        score = score + 10;
        tekstvakje.text = score.ToString();
    }
}
