using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCharacter : MonoBehaviour
{

    public DatabaseCharacter dbCharacter;
  
    public SpriteRenderer artworkSprite;

    private int selectOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectOption"))
        {
            selectOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharcter(selectOption);
    }

    public void UpdateCharcter(int selectOption)
    {
        CharacterSelect character = dbCharacter.GetCharacter(selectOption);
        artworkSprite.sprite = character.characterSprite;
        
    }

    private void Load()
    {
        selectOption = PlayerPrefs.GetInt("selectOption");
    }
}
