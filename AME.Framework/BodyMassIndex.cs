using System;

/// <summary>
/// Calculates BMI (uses Pounds and inches)
/// </summary>
public class BodyMassIndex
{
    private double weight;
    private double height;
    private double bmi;
    
    /// <summary>
    /// Computes a BMI value using weight and height params.
    /// </summary>
    /// <param name="initWeight"></param>
    /// <param name="initHeight"></param>
    public BodyMassIndex(double initWeight, double initHeight)
    {
        weight = initWeight;
        height = initHeight;
    }

    /// <summary>
    /// Gets the BMI value.
    /// </summary>
    /// <returns>Returns the calculated BMI.</returns>
    public double getBMI()
    {
        return bmi;
    }

    /// <summary>
    /// Calculates BMI.
    /// </summary>
    /// <remarks>
    /// Formula: weight (lb) / [height (in)] ^ 2 x 703
    /// </remarks>
    public void CalculateBMI()
    {
        bmi = weight / Math.Pow(height, 2) * 703;
    }
}