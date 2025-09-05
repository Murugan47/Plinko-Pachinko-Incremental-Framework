using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public UpgradeManager upgradeManager;
    public TMP_Text displayPoints;
    public float pointsScored;

    // In future points needs to be converted to scientific notation
    public float points;

    private int multi = 2;

    public void Start()
    {
        displayPoints.SetText("Points:" + points.ToString("F2"));
    }

    public void ScoringCalculator(string zoneScored)
    {
        bool isDouble = false;

        if (upgradeManager.doublePointChance > 0)
        {
            if (Random.value < upgradeManager.doublePointChance)
            {
                isDouble = true;
            }
        }

        switch (zoneScored)
        {
            case "Jackpot":
                if (isDouble)
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.jackpotMultiplier * multi);
                }
                else
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.jackpotMultiplier);
                }
                break;

            case "LeftRight":
                if (isDouble)
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.leftRightMultiplier * multi);
                }
                else
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.leftRightMultiplier);
                }
                break;

            case "CenterLeftRight":
                if (isDouble)
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.centerLeftRightMultiplier * multi);
                }
                else
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.centerLeftRightMultiplier);
                }
                break;

            case "Center":
                if (isDouble)
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.centerMultiplier * multi);
                }
                else
                {
                    pointsScored = (upgradeManager.ballBasePoints * upgradeManager.centerMultiplier);
                }
                break;
        }

        points += pointsScored;
        pointsScored = 0;
        displayPoints.SetText("Points:" + points.ToString("F2"));
    }
}