using Rocket.API;

namespace UconomyUI.By.PrincipeIan
{
    public class UconomyUIConfig : IRocketPluginConfiguration
    {
        public string colorBalance;
        public string serverName;
        public string colorName;
        public void LoadDefaults()
        {
            colorBalance = "#06B409";
            serverName = "ServerName";
            colorName = "#B43E06";
        }
    }
}