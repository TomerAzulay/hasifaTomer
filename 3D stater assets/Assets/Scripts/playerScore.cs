using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerScore : MonoBehaviour
{
    int score = 0;
    public Text pScore;
    int maxscore = 9;
    public GameObject door ;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PuzzleRed"))
        {
            score = Mathf.Clamp(score = +3,0,maxscore);

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Mathf.Min (score = 0,0);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pScore.text = score.ToString();
        if (score>=3)
        {
            Destroy(door);
            
        }

    }
}
