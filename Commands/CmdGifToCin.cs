namespace MCForge
{
    using System;
    public class CmdQuestion: Command
    {
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
        public override void Help(Player p) { Player.SendMessage(p, "/Question <player> <number> - asks <player> a question <number> about his map. Number 1: Did he make it alone? Number 2: Did he ask for a review before? "); }
        public override bool museumUsable { get { return true; } }
        public override string name { get { return "question"; } }
        public override string shortcut { get { return "ques"; } }
        public override string type { get { return "other"; } }
        public void Use(Player p, String message)
        {
        	if (message.split(' ').Length != 2) {Player.SendMessage(p, "Wrong number of arguments"); Help(p); return; }
        	string text = message.Split(' ')[0);
        	int number;
        	try { number = Integer.Parse(message.split(' ')[1]) }
        	catch { Player.SendMessage(p, "Error parsing prarameter 2"); Help(p); return; }
        }
        if (number == 1)
        {
        	Player.GlobalMessage(player.color + player.voicestring + player.color + player.prefix + player.name + ": &f" + text + ", did you make the whole map alone?");
        }
        if (number == 2)
        {
        	Player.GlobalMessage(player.color + player.voicestring + player.color + player.prefix + player.name + ": &f" + text +", have you got an review for this before, and if you did, what did you add after this?");
        }
        if (number != 1)
        {
        	if (number != 2)
        	{
        		Player.SendMessage(p, "Invalid number."	
        	}
        }
    }
}
        











/*{
            if (message.Split(' ').Length > 1)
            {
                if (player != null)
                {
                    message = message.Substring(message.IndexOf(' ') + 1);
                    //Player.GlobalMessage(player.color + player.voicestring + player.color + player.prefix + player.name + ": &f" + message);
                    Player.GlobalChat(player, message);
                }
                else
                {
                    string playerName = message.Split(' ')[0];
                    message = message.Substring(message.IndexOf(' ') + 1);
                    Player.GlobalMessage(playerName + ": &f" + message);
                }
            }
            else { Player.SendMessage(p, "No message was given."); }
        }
        public override void Use(Player p, string message)
        {
            if ((message == "")) { this.Help(p); }
            else
            {
                Player player = Player.Find(message.Split(' ')[0]);
                if (player != null)
                {
                    if (p == null) { this.SendIt(p, message, player); }
                    else
                    {
                        if (player == p) { this.SendIt(p, message, player); }
                        else
                        {
                            if (p.group.Permission > player.group.Permission) { this.SendIt(p, message, player); }
                            else { Player.SendMessage(p, "You cannot impersonate a player of equal or greater rank."); }
                        }
                    }
                }
                else
                {
                    if (p != null)
                    {
                        if (p.group.Permission >= LevelPermission.Admin)
                        {
                            if (Group.findPlayerGroup(message.Split(' ')[0]).Permission < p.group.Permission) { this.SendIt(p, message, null); }
                            else { Player.SendMessage(p, "You cannot impersonate a player of equal or greater rank."); }
                        }
                        else { Player.SendMessage(p, "You are not allowed to impersonate offline players"); }
                    }
                    else { this.SendIt(p, message, null); }
                }
            }
        }
    }
}