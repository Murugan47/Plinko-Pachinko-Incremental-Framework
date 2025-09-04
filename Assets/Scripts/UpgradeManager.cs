using UnityEngine;

public class UpgradeManager : MonoBehaviour
{

    // Ball Upgrades (Count:4)
    public float ballSpawnSpeed = 5f; //Done
    public float ballBasePoints = 1f; //Done
    public float ballCollisionCombo = 1f; //WIP
    public float collisionScoreAddition = 0f; //Done

    // Zone Upgrades (Count:4)
    public float jackpotMultiplier = 2f; //Done
    public float leftRightMultiplier = 1.25f; //Done
    public float centerLeftRightMultiplier = 0.75f; //Done
    public float centerMultiplier = 0.5f; //Done


    // Idle Upgrades (Count:4)
    // Scrap that shit --> superior wayyy --> based on time passed find out how many balls spawned in that time
    // Calculate shit based on that. ROUND UP FOR THE USERS SAKE
    public float idleHourMax = 2f;
    public float idleProductionPower = 0.25f;
    public float idleEarningMultiplier = 1f;
    public string idleScoringZone = "Center";

    // Misc Upgrades (Count:4)
    public float collisionCritChance = 0f; //Done
    public float gameSpeedMultiplier = 1; //Start done, needs to be updated per upgrade
    public float bonusBallChance = 0f; //Done
    public float doublePointChance = 0f; //Done
    

}
