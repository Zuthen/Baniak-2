using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSlot : MonoBehaviour
{
    public Character character;

    private void Start()
    {
        GetComponentInChildren<Image>().sprite = character.avatar;
        GetComponentInChildren<Text>().text = character.characterName;
    }

    public void ChangeCharacter()
    {
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        player.animator.runtimeAnimatorController = character.animator;
    }
}
