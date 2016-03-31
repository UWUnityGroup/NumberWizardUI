using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    public Text guessText, guessLeftText;
    public int maxGuessesAllowed = 10;

    int max, min, guess;
	
	// Use this for initialization
	void Start () {	
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void StartGame () {
		max = 1000;
		min = 1;

        GuessNumber();
	}

    public void GuessHigher()
    {
        min = guess;
        GuessNumber();
    }

    public void GuessLower()
    {
        max = guess;
        GuessNumber();
    }

    public void GuessCorrect()
    {
        SceneManager.LoadScene("Lose");
    }

    void GuessNumber () {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

        maxGuessesAllowed--;
        guessLeftText.text = maxGuessesAllowed.ToString();

        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
