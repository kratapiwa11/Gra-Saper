using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private const int GridSize = 10; //TO JEST wielkosc siatki grid czyli 10
    private const int KolumnaSize = 40; // to jest wielkosc kolmny czli 40
    private Button[,] buttons = new Button[GridSize, GridSize];
    private bool[,] mines = new bool[GridSize, GridSize];
    private int liczbamin = 10;

    public Form1()
    {
        this.Text = "Saper";
        this.ClientSize = new Size(GridSize * KolumnaSize, GridSize * KolumnaSize);
        InitializeGrid();
        liczbamin();
        CalculateNumbers();
    }
    // x i y pionowo i poziomo
 private void InitializeGrid()
    {
        for (int x = 0; x < GridSize; x++)
        {
            for (int y = 0; y < GridSize; y++)
            {
                buttons[x, y] = new Button();
                buttons[x, y].Size = new Size(KolumnaSize, KolumnaSize);
                buttons[x, y].Location = new Point(x * KolumnaSize, y * KolumnaSize);
                buttons[x, y].Click += new EventHandler(Button_Click);
                this.Controls.Add(buttons[x, y]);
                }
