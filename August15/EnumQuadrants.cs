using System;
using System.Reflection;

namespace August15
{
    public enum EnumQuadrants
    {
        [EnumManager.DisplayText("First Quadrant")] FirstQuadrant,
        [EnumManager.DisplayText("Second Quadrant")] SecondQuadrant,
        [EnumManager.DisplayText("Third Quadrant")] ThirdQuadrant,
        [EnumManager.DisplayText("Fourth Quadarant")] FourthQuadrant,
        [EnumManager.DisplayText("Oregon")] Oregon
    }

    
}