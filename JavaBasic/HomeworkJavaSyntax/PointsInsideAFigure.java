import java.util.Scanner;

public class PointsInsideAFigure {

	public static void main(String[] args) {
		Scanner reader = new Scanner(System.in);
		System.out.println("Enter cordinates 'a' and 'b' separate by space");
		double pointA = reader.nextDouble();
		double pointB = reader.nextDouble();
		
		boolean pointInside = PointsInsideAFigure(pointA,pointB);
		if (pointInside) {
			System.out.println("Inside");
		}
		else {
			System.out.println("OutSide");
		}

	}

	private static boolean PointsInsideAFigure(double pointA, double pointB) {
		boolean insideUpper = (pointA >= 12.5 && pointA <= 22.5 && pointB >= 6 && pointB <= 8.5);
		boolean insideLeft = (pointA >= 12.5 && pointA <= 17.5 && pointB >= 8.5 && pointB <= 13.5);
		boolean insideRight = (pointA >= 20.0 && pointA <= 22.5 && pointB >= 8.5 && pointB <= 13.5);
		boolean insideFigure = (insideUpper || insideLeft || insideRight);
		return insideFigure;
	}

}
