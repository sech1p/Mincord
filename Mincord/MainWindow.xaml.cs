using Mincord.Discord.API.APIs;
using Mincord.Structures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Mincord.Structures.User;
using Guild = Mincord.Structures.User.Guild;

namespace Mincord
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task<UserData> UserInfo()
        {
            var user = new Discord.API.APIs.User();
            var userInfo = await user.UserMe();
            return JsonConvert.DeserializeObject<UserData>(userInfo);
        }

        public async Task<List<Guild>> GuildsInfo()
        {
            var guilds = new Discord.API.APIs.Guild();
            var guildsInfo = await guilds.GetGuilds();
            var guildsObject = JsonConvert.DeserializeObject<List<Guild>>(guildsInfo);
            return guildsObject;

        }

        public async Task<List<Messages>> MessagesInfo(string channelId)
        {
            var messages = new Discord.API.APIs.Message(channelId);
            var messagesInfo = await messages.Messages(channelId);
            var messagesObject = JsonConvert.DeserializeObject<List<Messages>>(messagesInfo);
            return messagesObject;
        }

        private async void statusBar_Loaded(object sender, RoutedEventArgs e)
        {
            var user = await UserInfo();
            username.Text = $"{user.username} ({user.global_name})";
            messageTextBox.IsEnabled = false;
        }

        private async void username_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var user = await UserInfo();
            var userProfile = new UserProfileWindow(user);
            userProfile.Show();
        }

        private async void serverAndFriendsListBox_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var guilds = await GuildsInfo();

                serverAndFriendsListBox.Items.Clear();
                foreach (var guild in guilds)
                    serverAndFriendsListBox.Items.Add($"{guild.Name} {guild.Id}");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An error has occured.\r\n{exception.Message}", "Mincord", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void serverAndFriendsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var guildID = serverAndFriendsListBox.SelectedItem.ToString().Split('')[1].Split('')[0];
            var channelApi = new Discord.API.APIs.Channel();
            var channels = await channelApi.GetChannels(guildID);
            var channelsObject = JsonConvert.DeserializeObject<List<Structures.Channel>>(channels);

            channelsAndFriendsListBox.Items.Clear();
            foreach (var channel in channelsObject)
                if (channel.Type != 4) // TODO: Implement categories
                    if (channel.Type == 0) // Text channel
                        channelsAndFriendsListBox.Items.Add($"💬 {channel.Name} {channel.Id}");
                    else if (channel.Type == 2) // Voice channel
                        channelsAndFriendsListBox.Items.Add($"🎤 {channel.Name}");
        }


        private async void LoadMessages()
        {
            var stylesheet = new StreamReader("style.css").ReadToEnd();
            var channelId = channelsAndFriendsListBox.SelectedItem.ToString().Split('')[1].Split('')[0];
            var messagesApi = new Message(channelId);
            var messages = await messagesApi.Messages(channelId);
            var messagesObject = JsonConvert.DeserializeObject<List<Structures.Messages>>(messages);
            var messagesWeb = "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<meta charset=\"UTF-8\">" +
                "<style>" +
                $"{stylesheet}" +
                "</style>" +
                "<title>Mincord</title>" +
                "</head>" +
                "<body>";
            var avatar = "";

            foreach (var message in messagesObject)
            {
                avatar = message.Author.Avatar == null ?
                    "https://cdn.discordapp.com/embed/avatars/0.png" :
                    $"https://cdn.discordapp.com/avatars/{message.Author.Id}/{message.Author.Avatar}";
                messagesWeb += $"<hr><div id=\"avatar\"><img src=\"https://raw.githubusercontent.com/AndroidWG/WLMOnline/master/assets/background/frame_96.png\" /><img class=\"avatar\" src=\"{avatar}\" /></div>{message.Author.Username} ({Convert.ToDateTime(message.Timestamp)})<br>{message.Content}<br><br>";
            }
            messageTextBox.IsEnabled = true;
            main.NavigateToString(messagesWeb);
        }

        private async void channelsAndFriendsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LoadMessages();
        }

        private async void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var channelId = channelsAndFriendsListBox.SelectedItem.ToString().Split('')[1].Split('')[0];
            if (e.Key == Key.Enter)
            {
                var messageApi = new Message(channelId);
                await messageApi.SendMessage(channelId, messageTextBox.Text);
                messageTextBox.Text = "";
                LoadMessages();
            }
        }
    }
}
