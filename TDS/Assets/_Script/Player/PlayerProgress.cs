using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PlayerProgress : MonoBehaviour
{
    public List<PlayerProgressLevel> levels;

    public Slider Slider;
    public TextMeshProUGUI levelValueTMP;

    private int _levelValue = 1;

    private float _experienceCurrentValue = 0;
    private float _experienceTargetValue = 100;

    public AudioSource AudioSource;
    public AudioClip sound;

    private void Start()
    {
        SetLevel(_levelValue);
        DrawUI();
    }

    private void Update()
    {
        if(_levelValue == 10)
            SceneManager.LoadScene("EndGame");
    }

    public void AddExperience(float value) { 
        _experienceCurrentValue += value;
        if (_experienceCurrentValue >= _experienceTargetValue) {
           SetLevel(_levelValue + 1);
            _experienceCurrentValue = 0;
        }
        DrawUI();
    }

    private void SetLevel(int value) {
        _levelValue = value;

        var currentLevel = levels[_levelValue - 1];
        _experienceTargetValue = currentLevel.experienceForceTheNextLevel;
        GetComponent<FireballCaster>().damage = currentLevel.fireballDamage;

        var grenadeCaster = GetComponent<GrenadeCaster>();
        grenadeCaster.damage = currentLevel.grenadeDamage;
        if (currentLevel.grenadeDamage < 0)
            grenadeCaster.enabled = false;
        else grenadeCaster.enabled = true;
    }

    private void DrawUI()
    {
        Slider.value = _experienceCurrentValue/ _experienceTargetValue;
        levelValueTMP.text = _levelValue.ToString();
        AudioSource.PlayOneShot(sound);
    }
}
