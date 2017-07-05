using System;
public void Main()
{
	double r;
	Circle c;
	Console.Write("Enter radius to calculate the area of the circle: ");
	r=Convert.ToDouble(Console.ReadLine());
	c= New Circle(r);
	Console.WriteLine("The area is " +c.ComputeArea);

}
