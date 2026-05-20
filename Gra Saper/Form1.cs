using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private const int GridSize = 10;
    private const int CellSize = 40;
    private Button[,] buttons = new Button[GridSize, GridSize];
    private bool[,] mines = new bool[GridSize, GridSize];
    private int mineCount = 10;

    public Form1()
    {
        this.Text = "Saper";
      
    }