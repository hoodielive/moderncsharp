using System;

public class Car
{
	private string make;
	private string model;
	private string color;
	private int year;

	public void Start() {}
	public void Stop() {}
	public void Accelerate() {}

	public string GetMake() { return this.make; }
	public string GetModel() { return this.model; }
	public string GetYear() { return this.year; }
	public string GetColor() { return this.color; }

	public void SetMake(string make) { this.make = make; }
	public void SetModel(string model) { this.model = model; }
	public void SetYear(string year) { this.year = year; }
	public void SetColor(string color) { this.color = color; }

}
