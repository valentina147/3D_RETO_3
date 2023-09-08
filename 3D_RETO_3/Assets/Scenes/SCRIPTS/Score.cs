using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score: MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto;
    public static int score;
    private void Start()
    {
        score = 0;
    }
    void Update()
    {
        texto.text = string.Format("X {0}", score);
    }
}
