using System.Collections.Generic;
using System.Windows.Controls;


namespace WeltraumShooter2022_2023.CLASSES
{
    static class Global
    {
        // Wichtige Konstanten und wichtige Windows Objekte
        static internal Canvas SpaceCanvas { get; set; }

        // Weltraum Objekte
        static internal SpaceShip spaceShip { get; set; }

        // Listen
        static internal List<Star> star_list = new List<Star>();


        static internal void InitializeAllSpaceObjects()
        {
            spaceShip = new SpaceShip();


            for (int i = 0; i < 100; i++)
            {
                star_list.Add(new Star());
            }

        }

    }
}
