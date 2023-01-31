using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;

namespace RPMessages
{
    public class AnonCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "nrp";
        public string Help => "Сообщение в глобальный чат - NRP.";
        public string Syntax => "<>";
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string>() { "shamhyper.nrp" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            string img = player.SteamProfile.AvatarIcon.ToString();
            string text = "";
            for (int i = 0; i < command.Length; i++)
            {
                text += command[i] + " ";
            }
            text = text.Trim(' ');
            ChatManager.serverSendMessage($"[NON-RP] {player.CharacterName}: {text}", Color.grey, default, default, EChatMode.GLOBAL, img);
        }
    }
}
