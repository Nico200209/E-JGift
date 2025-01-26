using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicPlayer : MonoBehaviour
{
    public List<AudioClip> musicTracks; // List of songs to shuffle
    private AudioSource audioSource;
    private List<AudioClip> shuffledTracks;
    private int currentTrackIndex;

    private static BackgroundMusicPlayer instance; // Singleton instance

    void Awake()
    {
        // Implement Singleton pattern
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Ensure the object persists across scenes

        // Add and configure the AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false; // Don't loop individual tracks
        audioSource.playOnAwake = false;

        if (musicTracks.Count > 0)
        {
            ShuffleTracks(); // Shuffle the tracks initially
            PlayNextTrack();
        }
        else
        {
            Debug.LogError("No music tracks assigned!");
        }
    }

    void Update()
    {
        // Check if the current track has finished playing
        if (!audioSource.isPlaying && musicTracks.Count > 0)
        {
            PlayNextTrack();
        }
    }

    private void ShuffleTracks()
    {
        shuffledTracks = new List<AudioClip>(musicTracks);

        for (int i = 0; i < shuffledTracks.Count; i++)
        {
            int randomIndex = Random.Range(0, shuffledTracks.Count);
            AudioClip temp = shuffledTracks[i];
            shuffledTracks[i] = shuffledTracks[randomIndex];
            shuffledTracks[randomIndex] = temp;
        }

        currentTrackIndex = 0; // Reset track index
    }

    private void PlayNextTrack()
    {
        if (currentTrackIndex >= shuffledTracks.Count)
        {
            ShuffleTracks(); // Reshuffle once all tracks have played
        }

        if (shuffledTracks.Count > 0)
        {
            audioSource.clip = shuffledTracks[currentTrackIndex];
            audioSource.Play();
            currentTrackIndex++;
        }
    }
}