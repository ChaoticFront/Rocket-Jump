using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] TextMeshProUGUI scoreText;

       void Update()
    {
        scoreText.text = player.position.x.ToString("0");
    }
}
