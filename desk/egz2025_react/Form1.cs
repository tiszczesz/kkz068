namespace egz2025_react
{
    public partial class Form1 : Form
    {
        private List<ImageData> imageDataList = ImageDataRepo.GetImageDataList();
        public Form1()
        {
            InitializeComponent();
            CreateDynamicPanels(flowLayoutPanel1);
            checkBoxAnimals.Checked = true;
            checkBoxFlower.Checked = true;
            checkBoxCars.Checked = true;
        }
        private void CreateDynamicPanels(FlowLayoutPanel flowLayoutPanel1)
        {
            // Liczba paneli do stworzenia


            // Pêtla do tworzenia paneli i przycisków
            foreach (var elem in imageDataList)
            {
                // Tworzenie nowego panelu
                Panel panel = new Panel
                {
                    Name = $"Panel{elem.Id}",
                    Size = new Size(200, 250),
                    //Location = new Point(20, 20 + i * 110), // Ustawienie lokalizacji panelu
                    BorderStyle = BorderStyle.FixedSingle
                };
                PictureBox pictureBox = new PictureBox
                {
                    Name = $"PictureBox{elem.Id}",
                    Size = new Size(200, 150),

                };
                var imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", elem.Filename);
                LoadImageToPictureBox(pictureBox, imagePath);
                Label label = new Label
                {
                    Name = $"Label{elem.Id}",
                    Text = $"Pobrañ: {elem.Downloads}",
                    Size = new Size(200, 30),
                    Location = new Point(10, 160), // Lokalizacja etykiety w panelu
                    TextAlign = ContentAlignment.MiddleLeft,
                    // BackColor = Color.LightGray
                };
                // Tworzenie przycisku
                Button button = new Button
                {
                    Name = $"{elem.Id}",
                    Text = $"Pobierz",
                    Size = new Size(100, 30),
                    BackColor = Color.Green,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(10, 190) // Lokalizacja przycisku w panelu
                };

                // Subskrybowanie zdarzenia Click dla przycisku
                button.Click += (sender, e) =>
                {
                    //MessageBox.Show($"Klikniêto przycisk {((Button)sender).Text}", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (sender is Button clickedButton &&
                            int.TryParse(clickedButton.Name, out int id))
                    {
                        var imageData = imageDataList.FirstOrDefault(data => data.Id == id);
                        if (imageData != null)
                        {
                            imageData.Downloads++;
                            label.Text = $"Pobrañ: {imageData.Downloads}";
                        }
                    }
                };

                // Dodanie przycisku do panelu
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Controls.Add(button);

                // Dodanie panelu do formularza
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void LoadImageToPictureBox(PictureBox pictureBox, string imagePath)
        {
            try
            {
                // Wczytanie obrazu do PictureBox
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d wczytywania obrazu: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxFlower_CheckedChanged(object sender, EventArgs e)
        {
           FilterdImages();
        }

        private void checkBoxAnimals_CheckedChanged(object sender, EventArgs e)
        {
           
           FilterdImages();
        }

        private void checkBoxCars_CheckedChanged(object sender, EventArgs e)
        {
           FilterdImages();
        }
        private void FilterdImages() {
            foreach (var elem in imageDataList)
            {
                if (elem.Category == 1)
                {
                    var panel = flowLayoutPanel1.Controls.Find($"Panel{elem.Id}", true).FirstOrDefault();
                    if (panel != null)
                    {
                        panel.Visible = checkBoxFlower.Checked;
                    }
                }
                if (elem.Category == 2)
                {
                    var panel = flowLayoutPanel1.Controls.Find($"Panel{elem.Id}", true).FirstOrDefault();
                    if (panel != null)
                    {
                        panel.Visible = checkBoxAnimals.Checked;
                    }
                }
                if (elem.Category == 3)
                {
                    var panel = flowLayoutPanel1.Controls.Find($"Panel{elem.Id}", true).FirstOrDefault();
                    if (panel != null)
                    {
                        panel.Visible = checkBoxCars.Checked;
                    }
                }
            }
        }
    }

}
