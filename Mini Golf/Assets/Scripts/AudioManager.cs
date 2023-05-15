using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static AudioSource bgmSource;
    static AudioSource ballSfxSource;
    static AudioSource goalSfxSource;

    [SerializeField] AudioSource bgm;
    [SerializeField] AudioSource ballSfx;
    [SerializeField] AudioSource goalSfx;

    public bool IsMute { get => bgm.mute; }
    public float BgmVolume { get => bgm.volume; }
    public float BallSfxVolume { get => ballSfx.volume; }
    public float GoalSfxVolume { get => goalSfx.volume; }

    void Start()
    {
        if (bgmSource != null)
        {
            Destroy(bgm.gameObject);
            bgm = bgmSource;
        }
        else
        {
            bgmSource = bgm;
            bgm.transform.SetParent(null);
            DontDestroyOnLoad(bgm.gameObject);
        }

        if (ballSfxSource != null)
        {
            Destroy(ballSfx.gameObject);
            ballSfx = ballSfxSource;
        }
        else
        {
            ballSfxSource = ballSfx;
            ballSfx.transform.SetParent(null);
            DontDestroyOnLoad(ballSfx.gameObject);
        }

        if (goalSfxSource != null)
        {
            Destroy(goalSfx.gameObject);
            goalSfx = goalSfxSource;
        }
        else
        {
            goalSfxSource = goalSfx;
            goalSfx.transform.SetParent(null);
            DontDestroyOnLoad(goalSfx.gameObject);
        }
    }

    public void PlayBGM(AudioClip clip, bool loop = true)
    {
        if (bgm.isPlaying == true)
            bgm.clip = clip;

        bgm.loop = loop;
        bgm.Play();
    }

    public void PlayBallSfx(AudioClip clip)
    {
        if (ballSfx.isPlaying == true)
            ballSfx.Stop();

        ballSfx.clip = clip;
        ballSfx.Play();
    }

    public void PlayGoalSFX(AudioClip clip)
    {
        if (goalSfx.isPlaying == true)
            goalSfx.Stop();

        goalSfx.clip = clip;
        goalSfx.Play();
    }

    public void SetMute(bool v)
    {
        bgm.mute = v;
        ballSfx.mute = v;
        goalSfx.mute = v;
    }

    public void SetVolumeBGM(float v)
    {
        bgm.volume = v;
    }

    public void SetBallVolumeSFX(float v)
    {
        ballSfx.volume = v;
    }

    public void SetGoalVolumeSFX(float v)
    {
        goalSfx.volume = v;
    }
}
