using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DatabaseCharacter : ScriptableObject
{
    public CharacterSelect[] character;

    public int CharacterSelectCount
    {
        get
        {
            return character.Length;
        }
    }

    public CharacterSelect GetCharacter(int index)
    {
        return character[index];
    }
}
