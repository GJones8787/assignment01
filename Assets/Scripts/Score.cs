using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;//string for score
  
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");//float to string for score
    }
}
