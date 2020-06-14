﻿using System;
using Mars_Rover.Moldels;
using Mars_Rover.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CoordinatesModel> rovers = new List<CoordinatesModel>()
            {
                new CoordinatesModel() { X = 0, Y = 0, Orientation = OrientationType.North },
                new CoordinatesModel() { X = 1, Y = 0, Orientation = OrientationType.East }
            };
            CoordinatesModel selectedRover;
            Console.WriteLine("Upper-right coordinates of the plateau:");
            GetUpperRightCoordinates(out int upperRightX, out int upperRightY);

            Console.WriteLine("(Current coordinates of Rovers: 0 0 N , 1 0 E)");
            Console.WriteLine("Rover coordinates: ");
            selectedRover = GetRoverCoordinates(rovers);

        }

        private static CoordinatesModel GetRoverCoordinates(List<CoordinatesModel> rovers)
        {
            CoordinatesModel selectedRover;
            while (true)
            {
                string roverCoordinates = Console.ReadLine();
                string[] roverCoordinatesArray = roverCoordinates.Split(" ");
                if (roverCoordinatesArray.Length == 3)
                {
                    if (int.TryParse(roverCoordinatesArray[0], out int roverX) && int.TryParse(roverCoordinatesArray[1], out int roverY))
                    {
                        if (roverX > 0 && roverY > 0)
                        {
                            if (roverCoordinatesArray[2] == OrientationType.North.Value || roverCoordinatesArray[2] == OrientationType.South.Value
                                || roverCoordinatesArray[2] == OrientationType.East.Value || roverCoordinatesArray[2] == OrientationType.West.Value)
                            {
                                selectedRover = rovers.Where(r => r.X == roverX && r.Y == roverY && r.Orientation.Value == roverCoordinatesArray[2]).SingleOrDefault();
                                if (selectedRover != null)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("There is no rovers in these coordinates, please type correct coordinates.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is no rovers in these coordinates, please type correct coordinates.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no rovers in these coordinates, please type correct coordinates.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no rovers in these coordinates, please type correct coordinates.");
                    }
                }
                else
                {
                    Console.WriteLine("There is no rovers in these coordinates, please type correct coordinates.");
                }
            }

            return selectedRover;
        }

        private static void GetUpperRightCoordinates(out int upperRightX, out int upperRightY)
        {
            while (true)
            {
                string upperRightCoordinates = Console.ReadLine();
                string[] upperRightCoordinatesArray = upperRightCoordinates.Split(" ");
                if (upperRightCoordinatesArray.Length == 2)
                {
                    if (int.TryParse(upperRightCoordinatesArray[0], out upperRightX) && int.TryParse(upperRightCoordinatesArray[1], out upperRightY))
                    {
                        if (upperRightX > 0 && upperRightY > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Upper-right coordinates is not valid, please type correct.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Upper-right coordinates is not valid, please type correct.");
                    }
                }
                else
                {
                    Console.WriteLine("Upper-right coordinates is not valid, please type correct.");
                }
            }
        }
    }
}