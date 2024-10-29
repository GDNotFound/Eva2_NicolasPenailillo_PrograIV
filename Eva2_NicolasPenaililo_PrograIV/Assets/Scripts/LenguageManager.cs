using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LenguageManager : MonoBehaviour
{
    private ChangeLenguage lenguageChanger;
    private void Start()
    {
        PopulateDropDown();
        LoadValues();
        lenguageChanger = new ChangeLenguage();
        lenguageChanger.SetDictionary(lenguageChanger.lenguage);
    }
    public string GetTranslation(int key)
    {
        if (lenguageChanger.ActiveDictionary != null && lenguageChanger.ActiveDictionary.TryGetValue(key,out string translation))   
        {
            return translation;
        }
        return "Translation Not Found";
    }
    public TMP_InputField input_attackDamage;
    public TMP_InputField input_abilityPower;
    public TMP_InputField input_armor;
    public TMP_InputField input_magicResistance;
    public TMP_InputField input_attackSpeed;
    public TMP_InputField input_abilityHaste;
    public TMP_InputField input_criticalChance;
    public TMP_InputField input_movementSpeed;
    public TMP_InputField input_healthRegeneration;
    public TMP_InputField input_manaRegeneration;
    public TMP_InputField input_armorPenetration;
    public TMP_InputField input_magicPenetration;
    public TMP_InputField input_lifeSteal;
    public TMP_InputField input_spellSteal;
    public TMP_InputField input_range;
    public TMP_InputField input_tenacity;
    public Slider musicSlider;
    public TMP_Dropdown characterList;
    void PopulateDropDown()
    {
        int totalSlots = 5;
        for (int i = 0; i < totalSlots; i++)
        {
            characterList.options.Add(new TMP_Dropdown.OptionData("Slot" + i));
        }
    }
    public void SaveCharacter()
    {
        int slot = characterList.value;
        ChangeLenguage character = new ChangeLenguage
        {
            attackDamage = int.TryParse(input_attackDamage.text, out int attackDamage) ? attackDamage : 1,
            abilityPower = int.TryParse(input_abilityPower.text, out int abilityPower) ? abilityPower : 1,
            armor = int.TryParse(input_armor.text, out int armor) ? armor : 1,
            magicResistance = int.TryParse(input_magicResistance.text, out int magicResistance) ? magicResistance : 1,
            attackSpeed = int.TryParse(input_attackSpeed.text, out int attackSpeed) ? attackSpeed : 1,
            abilityHaste = int.TryParse(input_abilityHaste.text, out int abilityHaste) ? abilityHaste : 1,
            criticalChance = int.TryParse(input_criticalChance.text, out int criticalChance) ? criticalChance : 1,
            movementSpeed = int.TryParse(input_movementSpeed.text, out int movementSpeed) ? movementSpeed : 1,
            healthRegeneration = int.TryParse(input_healthRegeneration.text, out int healthRegeneration) ? healthRegeneration : 1,
            manaRegeneration = int.TryParse(input_manaRegeneration.text, out int manaRegeneration) ? manaRegeneration : 1,
            armorPenetration = int.TryParse(input_armorPenetration.text, out int armorPenetration) ? armorPenetration : 1,
            magicPenetration = int.TryParse(input_magicPenetration.text, out int magicPenetration) ? magicPenetration : 1,
            lifeSteal = int.TryParse(input_lifeSteal.text, out int lifeSteal) ? lifeSteal : 1,
            spellSteal = int.TryParse(input_spellSteal.text, out int spellSteal) ? spellSteal : 1,
            range = int.TryParse(input_range.text, out int range) ? range : 1,
            tenacity = int.TryParse(input_tenacity.text, out int tenacity) ? tenacity : 1,
        };
        string json = JsonUtility.ToJson(character);
        PlayerPrefs.SetString("CharacterData_" + slot, json);
        PlayerPrefs.Save();
    }
    public void LoadCharacter()
    {
        int slot = characterList.value;
        if (PlayerPrefs.HasKey("CharacterData_" + slot))
        {
            string json = PlayerPrefs.GetString("CharacterData_" + slot);
            ChangeLenguage character = JsonUtility.FromJson<ChangeLenguage>(json);
            input_attackDamage.text = character.attackDamage.ToString();
            input_abilityPower.text = character.abilityPower.ToString();
            input_armor.text = character.armor.ToString();
            input_magicResistance.text = character.magicResistance.ToString();
            input_attackSpeed.text = character.attackSpeed.ToString();
            input_abilityHaste.text = character.abilityHaste.ToString();
            input_criticalChance.text = character.criticalChance.ToString();
            input_movementSpeed.text = character.movementSpeed.ToString();
            input_healthRegeneration.text = character.healthRegeneration.ToString();
            input_manaRegeneration.text = character.manaRegeneration.ToString();
            input_armorPenetration.text = character.armorPenetration.ToString();
            input_magicPenetration.text = character.magicPenetration.ToString();
            input_lifeSteal.text = character.lifeSteal.ToString();
            input_spellSteal.text = character.spellSteal.ToString();
            input_range.text = character.range.ToString();
            input_tenacity.text = character.tenacity.ToString();

            Debug.Log("Character Loaded from Slot" + slot);
        }
        else Debug.Log(" No Character Data Loaded from Slot" + slot);
    }
    public void SaveVolumeButton()
    {
        float volumeValue = musicSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }
    void LoadValues()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        musicSlider.value = volumeValue;
    }
}
