using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionMenu : MonoBehaviour
{
    public void SelectCharacter(int index)
    {
        CharacterSelector.selectedCharacterIndex = index;
        SceneManager.LoadScene("PresentationScene");
    }
}
