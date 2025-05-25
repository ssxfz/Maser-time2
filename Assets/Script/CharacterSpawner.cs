using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject[] characterPrefabs; // Префаби героїв
    public Transform spawnPoint;

    void Start()
    {
        int index = CharacterSelector.selectedCharacterIndex;
        Instantiate(characterPrefabs[index], spawnPoint.position, Quaternion.identity);
    }
}
