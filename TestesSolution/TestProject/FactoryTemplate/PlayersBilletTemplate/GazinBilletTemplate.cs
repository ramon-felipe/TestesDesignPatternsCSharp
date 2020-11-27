using System;

namespace TestProject.FactoryTemplate.PlayersBilletTemplate
{
    internal class GazinBilletTemplate : IBilletTemplate
    {
        public string GetPlayerBilletTemplate()
        {
            return "Gazin Template...";
        }
    }
}