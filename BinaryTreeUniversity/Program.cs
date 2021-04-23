using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            //viserector financiero
            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;


            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;


            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;
        

            //Vicerector academico
            Position vicAcaPosition = new Position();
            vicAcaPosition.Name = "Vicerector Academico";
            vicAcaPosition.Salary = 780;

            Position jefeRegPosition  = new Position();
            jefeRegPosition.Name = "Jefe Registro";
            jefeRegPosition.Salary = 640;

            Position secAca1Position = new Position();
            secAca1Position.Name = "Secretaria Academica 1";
            secAca1Position.Salary = 400;

            Position asisAca1Position = new Position();
            asisAca1Position.Name = "Asistente Academico 1";
            asisAca1Position.Salary = 250;

            Position asisAca2Position = new Position();
            asisAca2Position.Name = "Asistente Academico 2";
            asisAca2Position.Salary = 170;

            Position mensAsisPosition = new Position();
            mensAsisPosition.Name = "Mensajero  de Asistente2";
            mensAsisPosition.Salary = 90;

            Position secAca2Position = new Position();
            secAca2Position.Name = "Secretaria Academica 2";
            secAca2Position.Salary = 360;


            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcaPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcaPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secAca1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asisAca1Position, secAca1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asisAca2Position, secAca1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensAsisPosition, asisAca2Position.Name);
            universityTree.CreatePosition(universityTree.Root, secAca2Position, jefeRegPosition.Name);



            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries:  { totalSalary}");
            Console.ReadLine();

        }
    }
}
