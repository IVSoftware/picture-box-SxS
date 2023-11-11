namespace picture_box_SxS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var pb in tableLayoutPanel.Controls.OfType<PictureBox>())
            {
                pb.Click += AddPictureBoxToPanel;
                pb.Click += AddPictureBoxToFlowLayoutPanel;
            }
            buttonShowByName.Click += ShowByName;
        }

        int _mainID = 0, flowID = 0;
        private void AddPictureBoxToPanel(object? sender, EventArgs e)
        {
            if (sender is PictureBox pbSrce)
            {
                var picture = new PictureBox
                {
                    Name = $"back_picturebox_{_mainID++}",
                    Size = new Size(120, 20),
                    BackColor = pbSrce.BackColor,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                var last = mainPanel.Controls.OfType<PictureBox>().LastOrDefault();
                if (last is null)
                {
                    picture.Location = new Point();
                }
                else
                {
                    picture.Location = new Point(last.Bounds.Right, last.Top);
                }
                mainPanel.Controls.Add(picture);
                Text = $"ADDED: {picture.Name} {picture.Bounds}";
            }
        }

        private void AddPictureBoxToFlowLayoutPanel(object? sender, EventArgs e)
        {
            if (sender is PictureBox pbSrce)
            {
                var picture = new PictureBox
                {
                    Name = $"back_picturebox_{flowID++}",
                    Size = new Size(120, 20),
                    BackColor = pbSrce.BackColor,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                flowLayoutPanel.Controls.Add(picture);
            }
        }

        private void ShowByName(object? sender, EventArgs e)
        {
            var boxesByName = new List<PictureBox>();
            for (int i = 0; i < _mainID; i++)
            {
                var name = $"back_picturebox_{i}";
                boxesByName.Add(mainPanel.Controls[name] as PictureBox);
            }
            var message =
                string.Join(
                    Environment.NewLine,
                    boxesByName.Select(_ => $"{_.Name} {_.Bounds}"));
            MessageBox.Show(message);
        }
    }
}