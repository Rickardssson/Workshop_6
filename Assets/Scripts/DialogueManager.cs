using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
   public TMP_Text namefield;
   public TMP_Text dialoguefield;
   
   private Queue<string> sentences;
   
   public Animator animator;

   private void Start()
   {
      sentences = new Queue<string>();
   }

   public void StartDialogue(Dialogue dialogue)
   {
      animator.SetBool("isOpen", true);
      namefield.text = dialogue.name;
      
      sentences.Clear();

      foreach (string sentence in dialogue.sentences)
      {
         sentences.Enqueue(sentence);
      }
      DisplayNextSentence();
   }

   public void DisplayNextSentence()
   {
      if (sentences.Count == 0)
      {
         Enddialogue();
         return;
      }
      string sentence = sentences.Dequeue();
      StopAllCoroutines();
      StartCoroutine(TypeSentence(sentence));
   }

   private IEnumerator TypeSentence(string sentence)
   {
      dialoguefield.text = "";
      foreach (char letter in sentence.ToCharArray())
      {
         dialoguefield.text += letter;
         yield return new WaitForSeconds(0.1f);
      }
   }

   private void Enddialogue()
   {
      StopAllCoroutines();
      animator.SetBool("isOpen", false);
      Debug.Log("Ending Conversation");
   }
}


