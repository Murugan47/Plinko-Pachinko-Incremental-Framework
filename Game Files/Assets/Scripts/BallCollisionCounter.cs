using System;
using Unity.VisualScripting;
using UnityEngine;

public class BallCollisionCounter : MonoBehaviour
{
    [SerializeField] private AudioClip[] bounceSoundClip;
    private int multi = 2;
    private float timer = 0;
    private int collisionCounter = 0;
    private float collisionComboScoreAddition;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Destroy(gameObject);
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        SoundManager.instance.BounceSoundEffect(bounceSoundClip, transform, 1f);

        PointManager pointManager = FindFirstObjectByType<PointManager>();
        UpgradeManager upgradeManager = FindFirstObjectByType<UpgradeManager>();

        collisionCounter++;
        bool isCrit = false;

        if (upgradeManager.collisionCritChance > 0)
        {
            if (UnityEngine.Random.value < upgradeManager.collisionCritChance)
            {
                isCrit = true;
            }
        }

        if (upgradeManager != null && pointManager != null && upgradeManager.collisionScoreAddition > 0 && isCrit)
        {
            if (upgradeManager.ballCollisionCombo > 0)
            {
                collisionComboScoreAddition = (upgradeManager.ballCollisionCombo * collisionCounter) + (upgradeManager.collisionScoreAddition);
                pointManager.points += (collisionComboScoreAddition * multi);
                pointManager.displayPoints.SetText("Points:" + pointManager.points.ToString("F2"));
            }

            else
            {
                pointManager.points += (upgradeManager.collisionScoreAddition);
                pointManager.displayPoints.SetText("Points:" + pointManager.points.ToString("F2"));
            }

        }
        else if (upgradeManager != null && pointManager != null && upgradeManager.collisionScoreAddition > 0)
        {
            if (upgradeManager.ballCollisionCombo > 0)
            {
                collisionComboScoreAddition = (upgradeManager.ballCollisionCombo * collisionCounter) + (upgradeManager.collisionScoreAddition);
                pointManager.points += (collisionComboScoreAddition);
                pointManager.displayPoints.SetText("Points:" + pointManager.points.ToString("F2"));
            }

            else
            {
                pointManager.points += (upgradeManager.collisionScoreAddition);
                pointManager.displayPoints.SetText("Points:" + pointManager.points.ToString("F2"));
            }
        }
    }
}