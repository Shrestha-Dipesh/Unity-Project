using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if (FindObjectOfType<GameManager>().gameHasEnded == true)
        {
            scoreText.text = "Game Over";
            scoreText.color = Color.red;
        }
    }
}
