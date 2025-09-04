using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // MainMenu Menu Bar
    public GameObject upgradeMenu;
    public GameObject skinsMenu;
    public GameObject prestigeMenu;
    public GameObject shopMenu;
    public GameObject settingsMenu;

    // UpgradeMenuBar
    public GameObject ballUpgradeTab;
    public GameObject zoneUpgradeTab;
    public GameObject idleUpgradeTab;
    public GameObject extraUpgradeTab;

    // SkinsMenuBar
    public GameObject ballSkinsTab;
    public GameObject backgroundSkinsTab;
    public GameObject bumpersSkinsTab;
    public GameObject scoreSkinsTab;

    // PrestigeMenuBar
    public GameObject prestigeTab;
    public GameObject prestigeUpgradeTab;

    // ShopMenuBar
    public GameObject purchasesTab;
    public GameObject adRewardsTab;

    // References for Alpha Changes
    public List<GameObject> upgradeTabButtons;
    public List<GameObject> skinsTabButtons;
    public List<GameObject> prestigeTabButtons;
    public List<GameObject> shopTabButtons;

    // Menu Sound Effect
    [SerializeField] private AudioClip menuSoundClip;

    public void SwitchMenus(string location)
    {
        switch (location)
        {
            case "Upgrade":
                upgradeMenu.SetActive(true);
                skinsMenu.SetActive(false);
                prestigeMenu.SetActive(false);
                shopMenu.SetActive(false);
                settingsMenu.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[0], 1f);
                SetButtonAlpha(skinsTabButtons[0], 0.5f);
                SetButtonAlpha(prestigeTabButtons[0], 0.5f);
                SetButtonAlpha(shopTabButtons[0], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "Skins":
                skinsMenu.SetActive(true);
                upgradeMenu.SetActive(false);
                prestigeMenu.SetActive(false);
                shopMenu.SetActive(false);
                settingsMenu.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[0], 0.5f);
                SetButtonAlpha(skinsTabButtons[0], 1f);
                SetButtonAlpha(prestigeTabButtons[0], 0.5f);
                SetButtonAlpha(shopTabButtons[0], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "Prestige":
                prestigeMenu.SetActive(true);
                skinsMenu.SetActive(false);
                upgradeMenu.SetActive(false);
                shopMenu.SetActive(false);
                settingsMenu.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[0], 0.5f);
                SetButtonAlpha(skinsTabButtons[0], 0.5f);
                SetButtonAlpha(prestigeTabButtons[0], 1f);
                SetButtonAlpha(shopTabButtons[0], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "Shop":
                shopMenu.SetActive(true);
                skinsMenu.SetActive(false);
                upgradeMenu.SetActive(false);
                prestigeMenu.SetActive(false);
                settingsMenu.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[0], 0.5f);
                SetButtonAlpha(skinsTabButtons[0], 0.5f);
                SetButtonAlpha(prestigeTabButtons[0], 0.5f);
                SetButtonAlpha(shopTabButtons[0], 1f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "Setting":
                settingsMenu.SetActive(true);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "SettingClose":
                settingsMenu.SetActive(false);
                MenuSoundPlayer(menuSoundClip);
                break;
        }
    }

    public void SwitchTabs(string location)
    {
        switch (location)
        {
            case "BallUpgrade":
                ballUpgradeTab.SetActive(true);
                zoneUpgradeTab.SetActive(false);
                idleUpgradeTab.SetActive(false);
                extraUpgradeTab.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[1], 1f);
                SetButtonAlpha(upgradeTabButtons[2], 0.5f);
                SetButtonAlpha(upgradeTabButtons[3], 0.5f);
                SetButtonAlpha(upgradeTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "ZoneUpgrade":
                zoneUpgradeTab.SetActive(true);
                ballUpgradeTab.SetActive(false);
                idleUpgradeTab.SetActive(false);
                extraUpgradeTab.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[1], 0.5f);
                SetButtonAlpha(upgradeTabButtons[2], 1f);
                SetButtonAlpha(upgradeTabButtons[3], 0.5f);
                SetButtonAlpha(upgradeTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "IdleUpgrade":
                idleUpgradeTab.SetActive(true);
                ballUpgradeTab.SetActive(false);
                zoneUpgradeTab.SetActive(false);
                extraUpgradeTab.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[1], 0.5f);
                SetButtonAlpha(upgradeTabButtons[2], 0.5f);
                SetButtonAlpha(upgradeTabButtons[3], 1f);
                SetButtonAlpha(upgradeTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "ExtraUpgrade":
                extraUpgradeTab.SetActive(true);
                ballUpgradeTab.SetActive(false);
                zoneUpgradeTab.SetActive(false);
                idleUpgradeTab.SetActive(false);
                SetButtonAlpha(upgradeTabButtons[1], 0.5f);
                SetButtonAlpha(upgradeTabButtons[2], 0.5f);
                SetButtonAlpha(upgradeTabButtons[3], 0.5f);
                SetButtonAlpha(upgradeTabButtons[4], 1f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "BallSkin":
                ballSkinsTab.SetActive(true);
                backgroundSkinsTab.SetActive(false);
                bumpersSkinsTab.SetActive(false);
                scoreSkinsTab.SetActive(false);
                SetButtonAlpha(skinsTabButtons[1], 1f);
                SetButtonAlpha(skinsTabButtons[2], 0.5f);
                SetButtonAlpha(skinsTabButtons[3], 0.5f);
                SetButtonAlpha(skinsTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "BackgroundSkin":
                backgroundSkinsTab.SetActive(true);
                ballSkinsTab.SetActive(false);
                bumpersSkinsTab.SetActive(false);
                scoreSkinsTab.SetActive(false);
                SetButtonAlpha(skinsTabButtons[1], 0.5f);
                SetButtonAlpha(skinsTabButtons[2], 1f);
                SetButtonAlpha(skinsTabButtons[3], 0.5f);
                SetButtonAlpha(skinsTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "BumperSkin":
                bumpersSkinsTab.SetActive(true);
                ballSkinsTab.SetActive(false);
                backgroundSkinsTab.SetActive(false);
                scoreSkinsTab.SetActive(false);
                SetButtonAlpha(skinsTabButtons[1], 0.5f);
                SetButtonAlpha(skinsTabButtons[2], 0.5f);
                SetButtonAlpha(skinsTabButtons[3], 1f);
                SetButtonAlpha(skinsTabButtons[4], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "ScoreSkin":
                scoreSkinsTab.SetActive(true);
                ballSkinsTab.SetActive(false);
                backgroundSkinsTab.SetActive(false);
                bumpersSkinsTab.SetActive(false);
                SetButtonAlpha(skinsTabButtons[1], 0.5f);
                SetButtonAlpha(skinsTabButtons[2], 0.5f);
                SetButtonAlpha(skinsTabButtons[3], 0.5f);
                SetButtonAlpha(skinsTabButtons[4], 1f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "PrestigeUser":
                prestigeTab.SetActive(true);
                prestigeUpgradeTab.SetActive(false);
                SetButtonAlpha(prestigeTabButtons[1], 1f);
                SetButtonAlpha(prestigeTabButtons[2], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "PrestigeUpgrade":
                prestigeUpgradeTab.SetActive(true);
                prestigeTab.SetActive(false);
                SetButtonAlpha(prestigeTabButtons[1], 0.5f);
                SetButtonAlpha(prestigeTabButtons[2], 1f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "PurchaseTab":
                purchasesTab.SetActive(true);
                adRewardsTab.SetActive(false);
                SetButtonAlpha(shopTabButtons[1], 1f);
                SetButtonAlpha(shopTabButtons[2], 0.5f);
                MenuSoundPlayer(menuSoundClip);
                break;

            case "AdReward":
                adRewardsTab.SetActive(true);
                purchasesTab.SetActive(false);
                SetButtonAlpha(shopTabButtons[1], 0.5f);
                SetButtonAlpha(shopTabButtons[2], 1f);
                MenuSoundPlayer(menuSoundClip);
                break;
        }
    }

    // Helper method to set the alpha value of a button's image
    private void SetButtonAlpha(GameObject button, float alpha)
    {
        Image buttonImage = button.GetComponent<Image>();
        if (buttonImage != null)
        {
            Color buttonColor = buttonImage.color;
            buttonColor.a = alpha;
            buttonImage.color = buttonColor;
        }
    }

    private void MenuSoundPlayer(AudioClip audioClip)
    {
        SoundManager.instance.MenuSoundEffect(audioClip, transform, 1f);
    }
}