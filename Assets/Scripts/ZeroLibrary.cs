using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this will be the library for zero's response to question.
/// </summary>
public class ZeroLibrary : MonoBehaviour
{

    [HideInInspector] public List<string> Questions = new List<string>();
    [HideInInspector] public List<string> UserAnswers = new List<string>();

    private void Awake()
    {

        Questions.Insert(0, "What is your name? ");
        Questions.Insert(1, "What is your age? ");
    }
}

