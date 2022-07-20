﻿using System;

namespace tarea_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradosAr, radianes;

            Console.Write("Ingresa los grados: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            radianes = GradosRadianes(gradosAr);

            Console.WriteLine("{0}° = {1} radianes", gradosAr, radianes);

        }

        static double GradosRadianes(double gradosPa)
        {
            double radianes;

            radianes = (gradosPa * Math.PI) / 180;

            return radianes;
        }
    }
}
