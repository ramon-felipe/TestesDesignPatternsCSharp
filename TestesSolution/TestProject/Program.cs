using System;
using TestProject.FactoryTemplate;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IBilletTemplate lyTemplate = PlayerBilletTemplateFactory.GetPlayerObject(PlayerNames.LY);
            IBilletTemplate gazinTemplate = PlayerBilletTemplateFactory.GetPlayerObject(PlayerNames.GAZIN);
            IBilletTemplate havanTemplate = PlayerBilletTemplateFactory.GetPlayerObject(PlayerNames.HAVAN);
            IBilletTemplate vivoTemplate = PlayerBilletTemplateFactory.GetPlayerObject(PlayerNames.VIVO);

            Console.WriteLine(lyTemplate.GetPlayerBilletTemplate());
            Console.WriteLine(gazinTemplate.GetPlayerBilletTemplate());
            Console.WriteLine(havanTemplate.GetPlayerBilletTemplate());
            Console.WriteLine(vivoTemplate.GetPlayerBilletTemplate());
        }
    }
}
