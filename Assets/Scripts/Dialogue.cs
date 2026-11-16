using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue/Dialogue")]
public class Dialogue : ScriptableObject
{
    public DialogueData[] dialogueData;
}

[System.Serializable]
public class DialogueData
{
    public Sprite img;
    public string text;
}