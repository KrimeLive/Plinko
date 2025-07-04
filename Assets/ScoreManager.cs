using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "$" + score.ToString() ;
    }

    public void AddPoint1()
    {
        score += 50;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint2()
    {
        score += 100;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint3()
    {
        score += 250;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint4()
    {
        score += 500;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint5()
    {
        score += 1000;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint6()
    {
        score += 1000;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint7()
    {
        score += 500;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint8()
    {
        score += 250;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint9()
    {
        score += 100;
        scoreText.text = "$" + score.ToString();
    }
    public void AddPoint10()
    {
        score += 50;
        scoreText.text = "$" + score.ToString();
    }
}
