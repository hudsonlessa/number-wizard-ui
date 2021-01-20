using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    public void OnPressLower() {
        max = guess - 1;
        GuessNext();
    }

    public void OnPressHigher() {
        min = guess + 1;
        GuessNext();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        GuessNext();
    }

    void GuessNext()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
