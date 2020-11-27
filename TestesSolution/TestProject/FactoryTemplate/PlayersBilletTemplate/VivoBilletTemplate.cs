using System;

namespace TestProject.FactoryTemplate.PlayersBilletTemplate
{
    internal class VivoBilletTemplate : IBilletTemplate
    {
        public string GetPlayerBilletTemplate()
        {
            return "Vivo template...";
        }
    }
}