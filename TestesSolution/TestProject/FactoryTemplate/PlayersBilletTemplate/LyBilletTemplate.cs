using System;

namespace TestProject.FactoryTemplate.PlayersBilletTemplate
{
    internal class LyBilletTemplate : IBilletTemplate
    {
        public string GetPlayerBilletTemplate()
        {
            return "LY template...";
        }
    }
}