using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.FactoryTemplate.PlayersBilletTemplate;

namespace TestProject.FactoryTemplate
{
    public class PlayerBilletTemplateFactory
    {
        public static IBilletTemplate GetPlayerObject(string playerName)
        {
            if (playerName.Equals(PlayerNames.LY))
            {
                return new LyBilletTemplate();
            }
            else if (playerName.Equals(PlayerNames.HAVAN))
            {
                return new HavanBilletTemplate();
            }
            else if (playerName.Equals(PlayerNames.GAZIN))
            {
                return new GazinBilletTemplate();
            }
            else if (playerName.Equals(PlayerNames.VIVO))
            {
                return new VivoBilletTemplate();
            }

            throw new ArgumentOutOfRangeException($"Não há billet template para este player: {nameof(playerName)}");
        }
    }
}
