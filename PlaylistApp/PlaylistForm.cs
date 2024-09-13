namespace PlaylistApp
{
    public partial class frmPlaylist : Form
    {
        public frmPlaylist()
        {
            InitializeComponent();
            loadImages();
            initializeDoublyLinkedList();
        }

        private CustomDoublyLinkedList<Track> playlist;

        private void initializeDoublyLinkedList()
        {
            playlist = new CustomDoublyLinkedList<Track>();

            string imageCover1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "adele_cover.jpg");
            string imageCover2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "bruno_mars_cover.png");
            string imageCover3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "celine_dion_cover.jpg");

            playlist.Add(new Track("Set Fire To Rain", "Adele", Image.FromFile(imageCover1)));
            playlist.Add(new Track("Marry You", "Bruno Mars", Image.FromFile(imageCover2)));
            playlist.Add(new Track("Ashes", "Celine Dion", Image.FromFile(imageCover3)));

            if (playlist.PrintFirst() != null)
            {
                picTrack.Image = playlist.PrintFirst().TrackImage;
                richTrackOutput.AppendText(playlist.PrintFirst().ToString());
            }


        }


        //loadImages() method checks if the images exists and loads into the respective PictureBox if successful.
        public void loadImages()
        {
            string imageBackgroundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "playlist_background.jpg");
            string imagePreviousPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "previous_icon.png");
            string imageNextPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "next_icon.png");
            string imageRemovePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "remove_icon.png");
            string imageAddPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "add_icon.png");
            string imageShuflePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "shuffle_icon.png");

            if (File.Exists(imageBackgroundPath) && File.Exists(imagePreviousPath) && File.Exists(imageNextPath)
                && File.Exists(imageRemovePath) && File.Exists(imageAddPath))
            {
                picBackground.Image = Image.FromFile(imageBackgroundPath);
                picBackground.SizeMode = PictureBoxSizeMode.StretchImage;

                picPrevious.Image = Image.FromFile(imagePreviousPath);
                picPrevious.SizeMode = PictureBoxSizeMode.StretchImage;

                picNext.Image = Image.FromFile(imageNextPath);
                picNext.SizeMode = PictureBoxSizeMode.StretchImage;

                picRemove.Image = Image.FromFile(imageRemovePath);
                picRemove.SizeMode = PictureBoxSizeMode.StretchImage;

                picAdd.Image = Image.FromFile(imageAddPath);
                picAdd.SizeMode = PictureBoxSizeMode.StretchImage;

                picShuffle.Image = Image.FromFile(imageShuflePath);
                picShuffle.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            string titleInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Track Title:", "Track Details");
            string artistInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Artist Name:", "Track Details");
            string imgPath = "";
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgPath = openFileDialog.FileName;
                }

                playlist.Add(new Track(titleInput, artistInput, Image.FromFile(imgPath)));

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void picNext_Click(object sender, EventArgs e)
        {
            clickNext();
        }



        private void picPrevious_Click(object sender, EventArgs e)
        {
            clickPrevious();

        }

        private void picRemove_Click(object sender, EventArgs e)
        {
            if (playlist.Remove().removed)
            {
                MessageBox.Show("Track has been removed successfully!");

                if (playlist.Remove().end)
                {
                    clickPrevious();
                }
                else
                {
                    clickNext();
                }
            }
            else
            {
                MessageBox.Show("Track removal failed!");
            }

        }

        private void clickNext()
        {
            var result = playlist.PrintNext();

            if (!result.reachedEnd)
            {
                picTrack.Image = result.data.Data.TrackImage;
                richTrackOutput.Clear();
                richTrackOutput.AppendText(result.data.Data.ToString());
            }
            else
            {
                MessageBox.Show("No more tracks in playlist!");
                playlist.ResetPrevious();
            }
        }

        private void clickPrevious()
        {
            var result = playlist.PrintPrevious();

            if (!result.reachedBeginning)
            {
                picTrack.Image = result.data.TrackImage;
                richTrackOutput.Clear();
                richTrackOutput.AppendText(result.data.ToString());
            }
            else
            {
                MessageBox.Show("You are at the beginning of playlist!");
                playlist.ResetNext();
            }
        }
    }
}
