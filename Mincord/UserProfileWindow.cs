using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mincord
{
    public partial class UserProfileWindow : Form
    {
        Structures.User.UserData _user;
        public UserProfileWindow(Structures.User.UserData user)
        {
            _user = user;
            InitializeComponent();
        }

        private void UserProfileWindow_Load(object sender, EventArgs e)
        {
            var avatarUri = new Uri($"{Discord.API.Endpoints.AVATAR_ENDPOINT}/{_user.id}/{_user.avatar}");

            this.Text = $"Profile of {_user.global_name}";
            userLabel.Text = _user.username;
            globalLabel.Text = _user.global_name;
            bioTextBox.Text = _user.bio;
            avatarPicture.Url = avatarUri;
        }
    }
}
