using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] TextMeshProUGUI scoreText;
    
    public static int scoreValue;

    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
        scoreValue = int.Parse(scoreText.text);
    }
}
