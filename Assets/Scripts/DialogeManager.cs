using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogeManager : MonoBehaviour
{
    public Dialogue dialogue;
    
    public TextMeshProUGUI textDisplay;
    public RawImage imageDisplay;

    int index = 0;
void Start()
    {
        DisplayDialogue(dialogue);
        imageDisplay.gameObject.SetActive(false);
    }
    public void DisplayDialogue(Dialogue dialogue)
    {
        textDisplay.text = dialogue.dialogueData[index].text;
        if(dialogue.dialogueData[index].img != null)
        {
            imageDisplay.gameObject.SetActive(true);
            imageDisplay.texture = dialogue.dialogueData[index].img.texture;
        }
        else
        {
            imageDisplay.texture = null;
            imageDisplay.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            index++;
            DisplayDialogue(dialogue);
        }
    }

    
}