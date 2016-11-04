using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public int lives;
    public Text tekstvakje;

    void Update()
    {
        tekstvakje.text = score.ToString();

    }

}
