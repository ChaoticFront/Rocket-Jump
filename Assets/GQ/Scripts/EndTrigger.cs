using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
