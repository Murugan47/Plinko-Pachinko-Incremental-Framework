using System;
using UnityEngine;
using TMPro;

public class UpgradeSystem : MonoBehaviour
{

    //BaseCostUpgradeList
    public int spawnSpeedCount = 0;
    public TMP_Text spawnSpeedCountText;
    public TMP_Text spawnSpeedCountCost;
    public int basePointCount = 0;
    public TMP_Text basePointCountText;
    public TMP_Text basePointCountCost;
    public int ballCollisionCombo = 0;
    public TMP_Text ballCollisionComboText;
    public TMP_Text ballCollisionComboCost;
    public int collisionScoreCount = 0;
    public TMP_Text collisionScoreCountText;
    public TMP_Text collisionScoreCountCost;

    //ZoneCostUpgradeList
    public int jackpotMultiplierCount = 0;
    public TMP_Text jackpotMultiplierCountText;
    public TMP_Text jackpotMultiplierCountCost;
    public int edgesMultiplierCount = 0;
    public TMP_Text edgesMultiplierCountText;
    public TMP_Text edgesMultiplierCountCost;
    public int centerEdgesMultiplierCount = 0;
    public TMP_Text centerEdgesMultiplierCountText;
    public TMP_Text centerEdgesMultiplierCountCost;
    public int centerMultiplierCount = 0;
    public TMP_Text centerMultiplierCountText;
    public TMP_Text centerMultiplierCountCost;

    //IdleCostUpgradeList
    public int idleHourMaxCount = 0;
    public TMP_Text idleHourMaxCountCost;
    public TMP_Text idleHourMaxCountText;
    public int idleProductionPowerCount = 0;
    public TMP_Text idleProductionPowerCountCost;
    public TMP_Text idleProductionPowerCountText;
    public int idleEarningMultiplierCount = 0;
    public TMP_Text idleEarningMultiplierCountCost;
    public TMP_Text idleEarningMultiplierCountText;
    public int idleScoringCount = 1;
    public TMP_Text idleScoringCountCost;
    public TMP_Text idleScoringCountText;

    //MiscCostUpgradeList
    public int collisionCritChanceCount = 0;
    public TMP_Text collisionCritChanceCountText;
    public TMP_Text collisionCritChanceCountCost;
    public int gameSpeedMultiplierCount = 0;
    public TMP_Text gameSpeedMultiplierCountText;
    public TMP_Text gameSpeedMultiplierCountCost;
    public int bonusBallChanceCount = 0;
    public TMP_Text bonusBallChanceCountText;
    public TMP_Text bonusBallChanceCountCost;
    public int doublePointChanceCount = 0;
    public TMP_Text doublePointChanceCountText;
    public TMP_Text doublePointChanceCountCost;

    public UpgradeManager upgradeManager;
    public PointManager pointManager;

    void Start()
    {
        Time.timeScale = upgradeManager.gameSpeedMultiplier;
    }

    // Ball Upgrade Functions List
    public void BallSpawnSpeedUpgrader()
    {

        float cost = 10 * Mathf.Pow(1.25f, spawnSpeedCount+1);
        spawnSpeedCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && spawnSpeedCount < 40)
        {
            spawnSpeedCount++;
            upgradeManager.ballSpawnSpeed -= 0.1f;
            pointManager.points -= cost;
            spawnSpeedCountText.SetText(spawnSpeedCount.ToString("F2"));
        }

    }

    public void BasePointUpgrader()
    {

        float cost = 100 * Mathf.Pow(1.25f, basePointCount) * (1 + Mathf.Abs(basePointCount - 20) / 10);
        basePointCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && basePointCount < 40)
        {
            basePointCount++;
            upgradeManager.ballBasePoints++;
            pointManager.points -= cost;
            basePointCountText.SetText(basePointCount.ToString("F2"));
        }

    }

    public void BallCollisionComboUpgrader()
    {

        float cost = 5000 * Mathf.Pow(5f, ballCollisionCombo+1);
        ballCollisionComboText.SetText("Price:" + cost);

        if (pointManager.points >= cost && ballCollisionCombo < 2)
        {
            ballCollisionCombo++;
            upgradeManager.ballCollisionCombo += 0.10f;
            pointManager.points -= cost;
            ballCollisionComboText.SetText(ballCollisionCombo.ToString("F2"));
        }

    }

    public void CollisionScoreUpgrader()
    {

        float cost = 600 * Mathf.Pow(1.16f, collisionScoreCount+1);
        collisionScoreCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && collisionScoreCount < 40)
        {
            collisionScoreCount++;
            upgradeManager.collisionScoreAddition += 0.10f;
            pointManager.points -= cost;
            collisionScoreCountText.SetText(collisionScoreCount.ToString("F2"));
        }

    }

    // Zone Upgrades Function List
    public void JackpotMultiplierUpgrade()
    {

        float cost = 1000 * Mathf.Pow(1.2f, jackpotMultiplierCount+1);
        jackpotMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && jackpotMultiplierCount < 40)
        {
            jackpotMultiplierCount++;
            upgradeManager.jackpotMultiplier += 0.05f;
            pointManager.points -= cost;
            jackpotMultiplierCountText.SetText(jackpotMultiplierCount.ToString("F2"));
        }

    }

    public void EdgesMultiplierUpgrade()
    {

        float cost = 800 * Mathf.Pow(1.18f, edgesMultiplierCount+1);
        edgesMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && edgesMultiplierCount < 40)
        {
            edgesMultiplierCount++;
            upgradeManager.leftRightMultiplier += 0.05f;
            pointManager.points -= cost;
            edgesMultiplierCountText.SetText(edgesMultiplierCount.ToString("F2"));
        }

    }

    public void CenterEdgesMultiplierUpgrade()
    {

        float cost = 600 * Mathf.Pow(1.16f, centerEdgesMultiplierCount+1);
        centerEdgesMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && centerEdgesMultiplierCount < 40)
        {
            centerEdgesMultiplierCount++;
            upgradeManager.centerLeftRightMultiplier += 0.05f;
            pointManager.points -= cost;
            centerEdgesMultiplierCountText.SetText(centerEdgesMultiplierCount.ToString("F2"));
        }

    }

    public void CenterMultiplierUpgrade()
    {

        float cost = 400 * Mathf.Pow(1.14f, centerMultiplierCount+1);
        centerMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && centerMultiplierCount < 40)
        {
            centerMultiplierCount++;
            upgradeManager.centerMultiplier += 0.05f;
            pointManager.points -= cost;
            centerMultiplierCountText.SetText(centerMultiplierCount.ToString("F2"));
        }

    }

    // Idle Upgrade Function List
    public void IdleHourMaxUpgrade()
    {
        float cost = 500 * Mathf.Pow(1.15f, idleHourMaxCount + 1);
        idleHourMaxCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && idleHourMaxCount < 40)
        {
            idleHourMaxCount++;
            upgradeManager.idleHourMax += 0.25f;
            pointManager.points -= cost;
            idleHourMaxCountText.SetText(idleHourMaxCount.ToString("F2"));
        }
    }

    public void IdleProductionPowerUpgrade()
    {
        float cost = 800 * Mathf.Pow(1.22f, idleProductionPowerCount + 1);
        idleProductionPowerCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && idleProductionPowerCount < 40)
        {
            idleProductionPowerCount++;
            upgradeManager.idleProductionPower += 0.05f;
            pointManager.points -= cost;
            idleProductionPowerCountText.SetText(idleProductionPowerCount.ToString("F2"));
        }
    }

    public void IdleEarningMultiplierUpgrade()
    {
        float cost = 800 * Mathf.Pow(1.25f, idleEarningMultiplierCount + 1);
        idleEarningMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && idleEarningMultiplierCount < 40)
        {
            idleEarningMultiplierCount++;
            upgradeManager.idleEarningMultiplier += 0.05f;
            pointManager.points -= cost;
            idleEarningMultiplierCountText.SetText(idleEarningMultiplierCount.ToString("F2"));
        }
    }

    public void idleScoringZoneUpgrade()
    {
        float cost = 2000 * Mathf.Pow(1.2f, idleScoringCount + 1);
        idleScoringCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && idleScoringCount < 4)
        {
            idleScoringCount++;
            switch (idleScoringCount)
            {
                case 1:
                upgradeManager.idleScoringZone = "Center";
                break;

                case 2: 
                upgradeManager.idleScoringZone = "CenterEdges"; 
                break;

                case 3: 
                upgradeManager.idleScoringZone = "Edges"; 
                break;

                case 4: 
                upgradeManager.idleScoringZone = "Jackpot"; 
                break;
            }

            pointManager.points -= cost;
            idleScoringCountText.SetText(idleScoringCount.ToString("F2"));
        }
    }

    // Extra Upgrade Function List
    public void CollisionCritChanceUpgrade()
    {

        float cost = 500 * Mathf.Pow(1.12f, collisionCritChanceCount+1);
        collisionCritChanceCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && collisionCritChanceCount < 40)
        {
            collisionCritChanceCount++;
            upgradeManager.collisionCritChance += 0.005f;
            pointManager.points -= cost;
            collisionCritChanceCountText.SetText(collisionCritChanceCount.ToString("F2"));
        }

    }

    public void GameSpeedMultiplierUpgrade()
    {

        float cost = 1000 * Mathf.Pow(1.2f, gameSpeedMultiplierCount+1);
        gameSpeedMultiplierCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && gameSpeedMultiplierCount < 40)
        {
            gameSpeedMultiplierCount++;
            upgradeManager.gameSpeedMultiplier += 0.025f;
            Debug.Log("Value of Game Speed" + upgradeManager.gameSpeedMultiplier);
            Time.timeScale = upgradeManager.gameSpeedMultiplier;
            pointManager.points -= cost;
            gameSpeedMultiplierCountText.SetText(gameSpeedMultiplierCount.ToString("F2"));
        }

    }

    public void BonusBallChanceUpgrade()
    {

        float cost = 500 * Mathf.Pow(1.12f, bonusBallChanceCount+1);
        bonusBallChanceCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && bonusBallChanceCount < 40)
        {
            bonusBallChanceCount++;
            upgradeManager.bonusBallChance += 0.00125f;
            pointManager.points -= cost;
            bonusBallChanceCountText.SetText(bonusBallChanceCount.ToString("F2"));
        }

    }

    public void DoublePointChanceCount()
    {

        float cost = 700 * Mathf.Pow(1.25f, doublePointChanceCount+1);
        doublePointChanceCountCost.SetText("Price:" + cost);

        if (pointManager.points >= cost && doublePointChanceCount < 40)
        {
            doublePointChanceCount++;
            upgradeManager.gameSpeedMultiplier += 0.00375f;
            pointManager.points -= cost;
            doublePointChanceCountText.SetText(doublePointChanceCount.ToString("F2"));  
        }

    }

}