using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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
using static System.Net.Mime.MediaTypeNames;

namespace Robot_OS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Reshetka();
            Robot();
        }

        public void Reshetka()
        {

            double Xmax = this.Height + 1920;
            double Ymax = this.Width + 1920;

            int k = 0;
            for (int i = 0; i < Xmax; i++)
            {
                Line vertL = new Line();
                {
                    vertL.X1 = k;
                    vertL.Y1 = Xmax;
                    vertL.X2 = k;
                    vertL.Y2 = 0;
                    k += 30;

                }
                vertL.Stroke = Brushes.White;
                canvas.Children.Add(vertL);
            }


            k = 0;
            for (int i = 0; i < Ymax; i++)
            {
                Line vertL = new Line();
                {
                    vertL.X1 = Ymax;
                    vertL.Y1 = k;
                    vertL.X2 = 0;
                    vertL.Y2 = k;
                    k += 30;

                }
                vertL.Stroke = Brushes.White;
                canvas.Children.Add(vertL);
            }


        }
        List<Line> lines = new List<Line>();
        private void Robot()
        {

            double X1 = 100;
            double X2 = 100;
            double Y1 = 350;
            double Y2 = 300;
            Line line1 = new Line();
            line1.Stroke = System.Windows.Media.Brushes.Red;
            line1.StrokeThickness = 10;
            line1.X1 = X1;
            line1.Y1 = Y1;
            line1.X2 = X2;
            line1.Y2 = Y2;
            lines.Add(line1);
            canvas.Children.Add(line1);
            Line line2 = new Line();
            line2.Stroke = System.Windows.Media.Brushes.Red;
            line2.StrokeThickness = 10;
            line2.X1 = X1+50;
            line2.Y1 = Y1;
            line2.X2 = X2+50;
            line2.Y2 = Y2;
            lines.Add(line2);
            canvas.Children.Add(line2);

            Line line3 = new Line();
            line3.Stroke = System.Windows.Media.Brushes.Red;
            line3.StrokeThickness = 10;
            line3.X1 = X1;
            line3.Y1 = Y1;
            line3.X2 = X2+50;
            line3.Y2 = Y1;
            lines.Add(line3);
            canvas.Children.Add(line3);

            Line line4 = new Line();
            line4.Stroke = System.Windows.Media.Brushes.Red;
            line4.StrokeThickness = 10;
            line4.X1 = X1+50;
            line4.Y1 = Y2;
            line4.X2 = X2;
            line4.Y2 = Y2;
            lines.Add(line4);
            canvas.Children.Add(line4);


        }
        private void Vertex_button_Click(object sender, RoutedEventArgs e)
        {
            //double X1 = 100+50;
            //double X2 = 100+50;
            //double Y1 = 400;
            //double Y2 = 300;
            Line line = lines[0];
            //line.X1 += 50;
            line.Y1 -= 20;
            //line.X2 += 50;
            line.Y2 -= 20;

            Line line2 = lines[1];
            //line.X1 += 50;
            line2.Y1 -= 20;
            //line.X2 += 50;
            line2.Y2 -= 20;

            Line line3 = lines[2];
            //line.X1 += 50;
            line3.Y1 -= 20;
            //line.X2 += 50;
            line3.Y2 -= 20;

            Line line4 = lines[3];
            //line.X1 += 50;
            line4.Y1 -= 20;
            //line.X2 += 50;
            line4.Y2 -= 20;

        }
        private void canvas_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
        private void canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(TPole.Document.ContentStart, TPole.Document.ContentEnd).Text;
            
            string[] comand = richText.Split(new char[] { '\n', '\r' });
            int timeComand = 1000;
            for (int i = 0; i < comand.Length; i++)
            {
                if (comand[i] == "StepX")
                {
                   double X= double.Parse(comand[i + 2]);
                    Te(X);
                   
                }
                else if (comand[i] == "StepY")
                {
                    double Y = double.Parse(comand[i + 2]);
                    Te(0,Y);
               
                }
                else if (comand[i] == "StepXY")
                {
                    double Y = double.Parse(comand[i + 2]);
                    double X = double.Parse(comand[i + 4]);
                    Te(X, Y);
                    
                }
                //  Thread.Sleep(timeComand);
            }
            MessageBox.Show("Программа выполнена");
        }
        private void Te(double X=0,double Y=0)
        {
            Line line = lines[0];
            line.X1 += X;
            line.Y1 += Y;
            line.X2 += X;
            line.Y2 += Y;

            Line line2 = lines[1];
            line2.X1 += X;
            line2.Y1 += Y;
            line2.X2 += X;
            line2.Y2 += Y;

            Line line3 = lines[2];
            line3.X1 += X;
            line3.Y1 += Y;
            line3.X2 += X;
            line3.Y2 += Y;

            Line line4 = lines[3];
            line4.X1 += X;
            line4.Y1 += Y;
            line4.X2 += X;
            line4.Y2 += Y;
        }
        private void Vertex_buttondown_Click(object sender, RoutedEventArgs e)
        {
            //double X1 = 100+50;
            //double X2 = 100+50;
            //double Y1 = 400;
            //double Y2 = 300;
            Line line = lines[0];
            //line.X1 += 50;
            line.Y1 += 20;
            //line.X2 += 50;
            line.Y2 += 20;

            Line line2 = lines[1];
            //line.X1 += 50;
            line2.Y1 += 20;
            //line.X2 += 50;
            line2.Y2 += 20;

            Line line3 = lines[2];
            //line.X1 += 50;
            line3.Y1 += 20;
            //line.X2 += 50;
            line3.Y2 += 20;

            Line line4 = lines[3];
            //line.X1 += 50;
            line4.Y1 += 20;
            //line.X2 += 50;
            line4.Y2 += 20;
        }
        private void Vertex_buttonpravo_Click(object sender, RoutedEventArgs e)
        {
            Line line = lines[0];
            line.X1 += 20;
            //line.Y1 += 20;
            line.X2 += 20;
            //line.Y2 += 20;

            Line line2 = lines[1];
            line2.X1 += 20;
            //line2.Y1 += 20;
            line2.X2 += 20;
            //line2.Y2 += 20;

            Line line3 = lines[2];
            line3.X1 += 20;
            //line3.Y1 += 20;
            line3.X2 += 20;
            //line3.Y2 += 20;

            Line line4 = lines[3];
            line4.X1 += 20;
            //line4.Y1 += 20;
            line4.X2 += 20;
            //line4.Y2 += 20;
        }
        private void Vertex_buttonlevo_Click(object sender, RoutedEventArgs e)
        {
            Line line = lines[0];
            line.X1 -= 20;
            //line.Y1 += 20;
            line.X2 -= 20;
            //line.Y2 += 20;

            Line line2 = lines[1];
            line2.X1 -= 20;
            //line2.Y1 += 20;
            line2.X2 -= 20;
            //line2.Y2 += 20;

            Line line3 = lines[2];
            line3.X1 -= 20;
            //line3.Y1 += 20;
            line3.X2 -= 20;
            //line3.Y2 += 20;

            Line line4 = lines[3];
            line4.X1 -= 20;
            //line4.Y1 += 20;
            line4.X2 -= 20;
            //line4.Y2 += 20;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = double.Parse(Text1.Text);
                double Y = double.Parse(Text2.Text);

                Line line = lines[0];
                line.X1 += X;
                line.Y1 += Y;
                line.X2 += X;
                line.Y2 += Y;

                Line line2 = lines[1];
                line2.X1 += X;
                line2.Y1 += Y;
                line2.X2 += X;
                line2.Y2 += Y;

                Line line3 = lines[2];
                line3.X1 += X;
                line3.Y1 += Y;
                line3.X2 += X;
                line3.Y2 += Y;

                Line line4 = lines[3];
                line4.X1 += X;
                line4.Y1 += Y;
                line4.X2 += X;
                line4.Y2 += Y;
            }
            catch (Exception)
            {

            }
          
        }
    }
}
