using UnityEngine;
using System.Collections;
[CreateAssetMenu(fileName = "BaseSong", menuName = "Abilities/Song", order = 1)]
public class Song : ScriptableObject
{
    public float bpm = 60;
    public Riff[] riffs;

}
[System.Serializable]
public struct Chord
{
    public bool b1,b2,b3,w1,w2,w3;
}

[System.Serializable]
public struct Riff
{
    public Chord[] chords;
}
