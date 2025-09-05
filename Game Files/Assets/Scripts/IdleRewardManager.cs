using UnityEngine;
using System;

public class IdleRewardManager : MonoBehaviour
{

    public UpgradeManager upgradeManager;
    public PointManager pointManager;

    void Start()
    {
        if (PlayerPrefs.HasKey("LastLoginTime"))
        {
            long temp = Convert.ToInt64(PlayerPrefs.GetString("LastLoginTime"));
            DateTime lastLoginTime = DateTime.FromBinary(temp);
            TimeSpan timeAway = DateTime.Now - lastLoginTime;

            Debug.Log("Time away: " + timeAway.TotalSeconds + " seconds");
            GiveIdleRewards(timeAway);
        }
    }

    void OnApplicationQuit()
    {
        SaveLastLoginTime();
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
            SaveLastLoginTime();
    }

    void SaveLastLoginTime()
    {
        string currentTime = DateTime.Now.ToBinary().ToString();
        PlayerPrefs.SetString("LastLoginTime", currentTime);
        PlayerPrefs.Save();
    }

    void GiveIdleRewards(TimeSpan timeAway)
    {
        double secondsAway = timeAway.TotalMinutes * 60;
        double maxAway = upgradeManager.idleHourMax * 60 * 60;

        if (secondsAway > upgradeManager.ballSpawnSpeed)
        {

            if (secondsAway >= maxAway)
            {

                switch(upgradeManager.idleScoringZone)
                {

                    case "Center":
                        double ballsSpawned = maxAway / upgradeManager.ballSpawnSpeed;
                        double idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.centerMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "CenterEdges":
                        ballsSpawned = maxAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.centerLeftRightMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "Edges":
                        ballsSpawned = maxAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.leftRightMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "Jackpot":
                        ballsSpawned = maxAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.jackpotMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                }

            } else if (secondsAway < maxAway) {

                switch(upgradeManager.idleScoringZone)
                {

                    case "Center":
                        double ballsSpawned = secondsAway / upgradeManager.ballSpawnSpeed;
                        double idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.centerMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "CenterEdges":
                        ballsSpawned = secondsAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.centerLeftRightMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "Edges":
                        ballsSpawned = secondsAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.leftRightMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                    case "Jackpot":
                        ballsSpawned = secondsAway / upgradeManager.ballSpawnSpeed;
                        idlePoints = ballsSpawned * upgradeManager.ballBasePoints * upgradeManager.idleEarningMultiplier * 
                        upgradeManager.idleProductionPower * upgradeManager.jackpotMultiplier;
                        pointManager.points += (float)idlePoints;
                    break;

                }

            }

        }


    }
}