using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    //Load all dialogue into queue
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        // initialize sentences
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentences);
        }

        DisplayNextSentence();
    }

    // check if sentence is already being displayed
    public void DisplayNextSentence ()
    {
        // If end of queue, end dialogue
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        
        // bring next sentence
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }
    
    void EndDialoguue()
    {
        Debug.Log("End of conversation.");
    }
}
