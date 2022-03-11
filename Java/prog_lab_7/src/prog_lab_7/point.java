package prog_lab_7;
import java.util.Scanner;

public class point {
	double x, y;
	String description;
	
	public point() {
		description = new String();
	}
	
	public void vvod() {
		Scanner in = new Scanner(System.in);
		this.x = in.nextDouble();
		this.y = in.nextDouble();
	}
	
	public void vivod()	{
		System.out.printf("(%f; %f)\n", this.x, this.y);
	}

	public double distance(point sdpoint) {
		return Math.sqrt(Math.pow(this.x - sdpoint.x, 2) + Math.pow(this.y - sdpoint.y, 2));
	}
	
	public double getx() {
		return this.x;
	}
	
	public double gety() {
		return this.y;
	}
	
	public void init(double x, double y) {
		this.x = x;//использование this
		this.y = y;
		return;
	}
	
	public void descrin() {
		Scanner in = new Scanner(System.in);
		description = in.nextLine();
	}
	
	public void descrout() {
		System.out.println(description);
	}
	
	public int sum() {
		return (int)(x+y);
	}
}