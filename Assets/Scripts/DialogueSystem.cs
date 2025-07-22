using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] private GameObject[] dialogueScenes;


    private void Awake()
    {
        for (int i = 1; i < dialogueScenes.Length; i++)
        {
            dialogueScenes[i].SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //this will be the one on top of the panels


    // Update is called once per frame
    void Update()
    {
        
    }
}
