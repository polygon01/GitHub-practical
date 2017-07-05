using System;
private double radius;
public double Radius
{
	get{return radius;}
	set{radius=value;}
}
public Circle(double r)
{
	this.radius=r;
}
public double ComputeArea()
{
	return 3.175*radius*radius;
}
