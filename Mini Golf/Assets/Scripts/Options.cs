using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider ballSfxSlider;
    [SerializeField] Slider goalSfxSlider;
    [SerializeField] TMP_Text bgmVolText;
    [SerializeField] TMP_Text ballSfxVolText;
    [SerializeField] TMP_Text goalSfxVolText;

    void Start()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
        ballSfxSlider.value = audioManager.BallSfxVolume;
        goalSfxSlider.value = audioManager.GoalSfxVolume;
        SetBgmVolText(bgmSlider.value);
        SetBallSfxVolText(ballSfxSlider.value);
        SetGoalSfxVolText(goalSfxSlider.value);
    }

    public void SetBgmVolText(float v)
    {
        bgmVolText.text = Mathf.RoundToInt(bgmSlider.value * 100).ToString();
    }

    public void SetBallSfxVolText(float v)
    {
        ballSfxVolText.text = Mathf.RoundToInt(ballSfxSlider.value * 100).ToString();
    }

    public void SetGoalSfxVolText(float v)
    {
        goalSfxVolText.text = Mathf.RoundToInt(goalSfxSlider.value * 100).ToString();
    }
}
