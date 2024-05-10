using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerCharacter : MonoBehaviour
{

    public DatabaseCharacter dbCharacter;
    public Text nameText;
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

    public void NextOption()
    {
        selectOption++;
        if(selectOption >= dbCharacter.CharacterSelectCount)
        {
            selectOption = 0;
        }

        UpdateCharcter(selectOption);
        Save();
    }

    public void BackOption()
    {
        selectOption--;
        if(selectOption < 0)
        {
            selectOption = dbCharacter.CharacterSelectCount - 1;
        }

        UpdateCharcter(selectOption);
        Save();
    }

    public void UpdateCharcter(int selectOption)
    {
        CharacterSelect character = dbCharacter.GetCharacter(selectOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }

    private void Load()
    {
        selectOption = PlayerPrefs.GetInt("selectOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectOptioin", selectOption);
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
