﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KhuzinaDR.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX.Replace('.', ','));
            double res = Math.Round(((Math.Cos(x) + (3 * x)) / (0.25 * x) + 4 - (2.1 * x)), 3);
            return res;
        }
    }
}