using System;

namespace TestProject.FactoryTemplate.PlayersBilletTemplate
{
    internal class HavanBilletTemplate : IBilletTemplate
    {
        public string GetPlayerBilletTemplate()
        {
            return "Havan template...";
        }
    }
}