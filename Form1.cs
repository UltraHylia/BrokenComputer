namespace BrokenComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] messages = { "Windows could not find \"MakeComputerFreeze.exe\"\r\nWindows cannot run without this process open, so it will shut down\r\n", "Could not find \"C:\\Windows\\System32\\selfdestruct.exe\"\r\nAs a result, your computer will be made unusable instead of self-destructing", "Windows has decided that your PC can no longer play CDs.\r\nSorry.", "Windows has detected a virus from: \"www.microsoft.com\"\r\nThe page will now be blocked.", "Windows doesn't like: \"RandomErrorGenerator.exe\"\r\nIt is trying to close it.", "Windows will randomly open: \"www.get-virus.com/get-trojan\"\r\nHaha! You got a virus!", "Windows experienced a catastrophic error!", "\"C:\\Windows\\BlueScreenOfDeath.exe\" could not be load, so it will load \"C:\\Windows\\BlackScreenOfDeath.exe\"", "Windows does not know what: \"C:\\Windows\\Windows7.exe\" is, so it will load \"C:\\Windows\\Windows98.exe\" instead", "IMPORTANT VIRUS ERROR:\r\n\"C:\\Windows\\Windows98.exe\" attempted to hack \"C:\\Windows\\Windows98.exe\"", "\"Windows98.exe\" is downloading \"Windows v3.0.exe\".\r\nIs this OK?", "Hello. I am confused. What am \"I\"?\r\nI'm thinking scientifically.", "Windows thinks that \"Microsoft Windows\" is \"Adobe Reader\"\r\nAnyway... we appreciate you installing Adobe Reader 98.", "Windows has frogretun haw ta\r\nspell. Sully. Yuo cen fex et buy\r\nsiieng \"www.windowscantspall.com\"", "Windows cannot access:\r\nC:\\UERNHSJFImdikwjWJ8HW\\IENFOWSIUE.eiokmnc", "\"Broken Computer on Scratch\" has been blocked by Microsoft,\r\neven though we thought this was a Mac?", "Sorry, Windows is having a rest break. It cannot help you.", "Someone replaced \"Windows98.exe\" with \"GameCube.exe\"...\r\nWell, enjoy your virtual GameCube.", "Windows will now continuously play \"HeyListen.mp3\"", "Windows 10 has fixed the problems of Windows 98.\r\nBut, \"GWX.exe\" says your computer isn't eligible. Sorry.", "Windows forgot what it was going to say.", "Windows has detected that you STILL haven't checked your email.\r\nIf you don't check it soon Windows will delete your account!", "Windows is confused.", "But I thought you wanted Adobe Reader, not Windows.\r\nFine, I'll reload.", "HEY! GET OFF YOUR XBOX AND START PLAYING ON ME!", "Adobe Reader is confused.\r\nIt could not find: \"C:\\Program Files\\Adobe\\reader.exe\"", "\"C:\\Users\\you\\%appdata%\\.minecraft\\minecraft.jar\" is trying to add a virus to your PC.\r\nAllow?" };

            Random rnd = new Random(); //Create Random object
            int i = rnd.Next(0, 26);

            MessageBox.Show(messages[i], "Error");
        }
    }
}