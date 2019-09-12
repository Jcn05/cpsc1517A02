using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //assume that you know how to do data input into
            //  a console application (CPSC1012)
            //the input data will simply be placed in a local variable
            
            //linearlength
            double linearlength = 135.0;
            //height
            double height = 6.5;
            //width
            double width = 8.0;
            //style
            string style = "Neighbour friendly: Spruce";
            //price
            double price = 108.00;

            //situation: have the required data for the class instance
            //options a) create instance using default constructor AND 
            //           multiple assignment statements
            //        b) create instance using greedy constructor
            //solution: b) one statement

            //FencePanel is a non-static class
            //Console was a static class
            //for a non-static class, you MUST create an instance of the class
            //      to be able to use the class
            //syntax using the new keyword which requires a reference to he
            //      appropriate class constructor
            FencePanel panel = new FencePanel(height, width, style, price);

            //handle numerous gates
            //create a class pointer able to reference the Gate class
            Gate gateinfo;

            //a structure to hold a collection of Gate
            //the structure to use should hold an unknown number of instances
            //structure will be a List<T>
            //create the new of the List<T> when it is defined
            List<Gate> gatelist = new List<Gate>();

            //assume you are in a loop to gather multiple gates

            //technique 1 
            //create instance of Gate
            //collect data
            //add to List
            gateinfo = new Gate();
            height = 6.25;
            width = 4.0;
            style = "Neighbour friendly - 1/2 picket: spruce";
            price = 86.45;

            gateinfo.Height = height;
            gateinfo.Width = width;
            gateinfo.Style = style;
            gateinfo.Price = price;
            gatelist.Add(gateinfo);

            //2nd gate
            //technique 2
            //collect data
            //create instance of Gate
            //add to List

            height = 6.25;
            width = 3.0;
            style = "Neighbour friendly: spruce";
            price = 72.45;
            gateinfo = new Gate(height, width, style, price);
            gatelist.Add(gateinfo);

            //create the Estimate
            Estimate ClientEstimate = new Estimate();
            ClientEstimate.LinearLength = linearlength;
            ClientEstimate.Panel = panel;
            ClientEstimate.Gates = gatelist;
            ClientEstimate.CalculatePrice();
        }
    }
}
