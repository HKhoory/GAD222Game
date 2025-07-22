using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class Dialogues : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private string[] lines;
    [SerializeField] private float textSpeed;
    [SerializeField] private GameObject test;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        text.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            test.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (text.text == lines[index])
            {
                NextDialogue();
            }

        }
        else
        {
            StopAllCoroutines();
            text.text = lines[index];
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeDialogue());
    }

    void NextDialogue()
    {
        if (index < lines.Length - 1)
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeDialogue());
        }
        else
        {
            test.SetActive(false);
            //gameObject.SetActive(false);
        }
    }


    IEnumerator TypeDialogue()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

}
