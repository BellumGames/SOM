using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pGraphic.BackColor = Color.White;
        }

        private static CustomGraphic g = new();
        private static readonly List<(int, int)> Points = new();
        private static readonly Neuron[,] Neurons = new Neuron[10, 10];
        private static Neuron[,] OriginalNeurons = new Neuron[10, 10];
        private static double t = 1;
        private static readonly double N = 10;
        private static double at = 0;
        private static double Vt = 0;
        private void BtnDrawInit(object sender, EventArgs e)
        {
            g = new CustomGraphic(pGraphic);
            DoubleBuffered = true;
            at = 0.7 * Math.Pow(Math.E, (-t / N));
            Vt = 6.1 * Math.Pow(Math.E, (-t / N));
            nAlpha.Value = (decimal)at;
            nV.Value = (decimal)Vt;
            Text = "Epoch " + t.ToString();
            t++;
            InitNeurons(Neurons);
            OriginalNeurons = Neurons;
            DrawNeurons(Neurons);
            Points.ForEach(Params =>
            {
                g.FillRectangle(Brushes.Black, Params.Item1, Params.Item2, 3, 3);
            });

        }
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                while (at > 0.00002 )
                {
                    g.Clear();
                    nAlpha.BeginInvoke((Action)(() =>
                    {
                        nAlpha.Value = (decimal)at;
                        nV.Value = (decimal)Vt;
                        Text = "Epoch " + t.ToString();
                        t++;
                    }));
                    Points.ForEach(Params =>
                    {
                        Neuron neuron = EuclidDistance(Params.Item1, Params.Item2);
                        g.FillRectangle(Brushes.Black, Params.Item1, Params.Item2, 3, 3);
                        for (int i = neuron.row - (int)(Math.Round(Vt)); i <= neuron.row + (int)(Math.Round(Vt) ); i++)
                        {
                            int ti = i;
                            for (int j = neuron.col - (int)(Math.Round(Vt) ); j <= neuron.col + (int)(Math.Round(Vt) ); j++)
                            {
                                int tj = j;
                                if (i >= 0 && i < 10 && j >= 0 && j < 10)
                                {
                                    Neurons[ti, tj].x += (float)(at * (Params.Item1 - OriginalNeurons[ti, tj].x));
                                    Neurons[ti, tj].y += (float)(at * (Params.Item2 - OriginalNeurons[ti, tj].y));
                                    //g.Clear();
                                    //g.FillRectangle(Brushes.Black, Params.Item1, Params.Item2, 5, 5);
                                    //DrawNeurons(Neurons);
                                    //System.Threading.Thread.Sleep(600);
                                }
                            }
                        }
                    });
                    at = 0.7 * Math.Pow(Math.E, (-t / N));
                    Vt = 6.1 * Math.Pow(Math.E, (-t / N));
                    DrawNeurons(Neurons);
                    System.Threading.Thread.Sleep(300);
                }
                nAlpha.BeginInvoke((Action)(() =>
                {
                    Text += " Finish";
                }));
            });
        }

        private static void InitNeurons(Neuron[,] neurons)
        {
            Neuron temp = new() { x = -275, y = -275, row = 0, col = 0 };
            for (temp.row = 0; temp.row < 10; temp.row++)
            {
                temp.y = -275;
                for (temp.col = 0; temp.col < 10; temp.col++)
                {
                    neurons[temp.row, temp.col] = new Neuron(temp);
                    temp.y += 60;
                }
                temp.x += 60;
            }
        }
        private static void DrawNeurons(Neuron[,] neurons)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Pen p = new(Brushes.Blue);
                    var ceva = neurons[i, j];
                    var altceva = neurons[i - 1, j];
                    g.DrawLine(p, new PointF(ceva.x, ceva.y), new PointF(altceva.x, altceva.y));
                    ceva = neurons[i - 1, j];
                    altceva = neurons[i - 1, j - 1];
                    g.DrawLine(p, new PointF(ceva.x, ceva.y), new PointF(altceva.x, altceva.y));


                    if (i == 9)
                    {
                        ceva = neurons[i, j];
                        altceva = neurons[i, j - 1];
                        g.DrawLine(p, new PointF(ceva.x, ceva.y), new PointF(altceva.x, altceva.y));
                    }
                    if (j == 1)
                    {
                        ceva = neurons[i, j - 1];
                        altceva = neurons[i - 1, j - 1];
                        g.DrawLine(p, new PointF(ceva.x, ceva.y), new PointF(altceva.x, altceva.y));
                    }
                }
            }
        }
        private static Neuron EuclidDistance(int item1, int item2)
        {
            Neuron n = new();
            double rez = int.MaxValue;

            foreach (var neuron in Neurons)
            {
                double temp = Math.Sqrt(Math.Pow(neuron.x - item1, 2) + Math.Pow(neuron.y - item2, 2));
                if (temp < rez)
                {
                    rez = temp;
                    n = neuron;
                }
            }
            return new Neuron(n);
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            g = new CustomGraphic(pGraphic);
            g.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPoints();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            btnDrawInit.PerformClick();
        }

        private static void LoadPoints()
        {
            Points.Clear();
            using StreamReader sr = new("Output.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string Line = sr.ReadLine();
                string[] Params = Line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                Points.Add((int.Parse(Params[0]), int.Parse(Params[1])));
                //g.FillRectangle(Brushes.Black, int.Parse(Params[0]), int.Parse(Params[1]), 3, 3);
            }
        }

    }
}
