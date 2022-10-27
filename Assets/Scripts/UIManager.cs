using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score : " + scoreManager.score;
    }
}