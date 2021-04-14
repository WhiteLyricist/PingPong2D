using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreBotT;
    [SerializeField] private TextMeshProUGUI scoreTopT;
    [SerializeField] private Image wonBotT;
    [SerializeField] private Image wonTopT;

    [SerializeField] private GameObject ball;

    private int scoreBot = 0;
    private int scoreTop = 0;

    // Start is called before the first frame update
    void Start()
    {
        MoveBall.OnScore += Score;
    }

    void Score(string side) 
    {
        if (side == "Bot") 
        {
            scoreTop += 1;
            scoreTopT.text = scoreTop.ToString();
            if (scoreTop >= 10) 
            {
                wonTopT.gameObject.SetActive(true);
                Destroy(ball);
                StartCoroutine(EndGame());
            }
        }

        if (side == "Top") 
        {
            scoreBot += 1;
            scoreBotT.text = scoreBot.ToString();
            if (scoreBot >= 10)
            {
                wonBotT.gameObject.SetActive(true);
                Destroy(ball);
                StartCoroutine(EndGame());
            }
        }
        
    }

    public IEnumerator EndGame() 
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Menu");
    }

    private void OnDestroy()
    {
        MoveBall.OnScore -= Score;
    }

    public void BackMenu() 
    {
        SceneManager.LoadScene("Menu");
    }

}
