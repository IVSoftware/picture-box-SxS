# Picture-Box-SxS

You have several options to **Add PictureBox next to another PictureBox**. To answer your specific question, _How do you get the Left and Width of the previously added PictureBox?_, one way is to do a `Linq` query on the `Controls` collection of `mainPanel`.

```
    int _mainID = 0;
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
```

[![screenshot][1]][1]


This screenshot shows a second option that "may or may not" be suitable for your project, which is to use a `FlowLayoutPanel` and let it worry about all those things.

```
    int flowID = 0;

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
```
___

A third option would be to create your new `PictureBox` objects with a name that's meaningful, index-wise. Then you can use the `string` indexer of the `Controls` collection to retrieve the one you want.

```
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
```

[![popup][2]][2]


  [1]: https://i.stack.imgur.com/Z1Ury.png
  [2]: https://i.stack.imgur.com/q2zJD.png