using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public void Hit()
    {
        score++;
    }
}