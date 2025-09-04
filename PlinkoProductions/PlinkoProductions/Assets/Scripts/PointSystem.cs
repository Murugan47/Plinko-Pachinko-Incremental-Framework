using System.Collections.Generic;
using UnityEngine;

public class PointScoring : MonoBehaviour
{

    [SerializeField] private AudioClip jackpotSoundClip;
    [SerializeField] private AudioClip edgesSoundClip;
    [SerializeField] private AudioClip centerEdgesSoundClip;
    [SerializeField] private AudioClip centerSoundClip;

    public PointManager pointManager;

    void OnTriggerEnter2D(Collider2D other)
    {

        // We check the tag of the object with the collider (not the collider itself)
        switch (gameObject.tag)  // Checking the tag of the zone GameObject
        {
            case "Jackpot":
                pointManager.ScoringCalculator("Jackpot");
                SoundManager.instance.ScoreSoundEffect(jackpotSoundClip, transform, 1f);
                DestroyBall(other);
                break;

            case "LeftRight":
                pointManager.ScoringCalculator("LeftRight");
                SoundManager.instance.ScoreSoundEffect(edgesSoundClip, transform, 1f);
                DestroyBall(other);
                break;

            case "CenterLeftRight":
                pointManager.ScoringCalculator("CenterLeftRight");
                SoundManager.instance.ScoreSoundEffect(centerEdgesSoundClip, transform, 1f);
                DestroyBall(other);
                break;

            case "Center":
                pointManager.ScoringCalculator("Center");
                SoundManager.instance.ScoreSoundEffect(centerSoundClip, transform, 1f);
                DestroyBall(other);
                break;
        }
    }

    void DestroyBall(Collider2D other)
    {
        // Check if the ball's tag matches
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
        }
    }
}
