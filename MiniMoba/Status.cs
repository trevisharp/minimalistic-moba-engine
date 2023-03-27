/*
 * Author: Leonardo Trevisan 
 * Date: March 27, 2023
 */

using System;

namespace MiniMoba;

/// <summary>
/// Represents a status with a minimum and maximun value.
/// </summary>
public class Status
{
    private int minValue = 0;
    private int maxValue = 0;
    private int crrValue = 0;

    /// <summary>
    /// Gets or sets the min value that current value can have.
    /// </summary>
    /// <value>The integer min value. The default value is 0.</value>
    public int MinValue
    {
        get => minValue;
        set
        {
            minValue =
                value > maxValue ?
                maxValue :
                value;
            
            if (crrValue < minValue)
                Current = minValue;
            
            minChanged();
        }
    }

    /// <summary>
    /// Gets or sets the max value that current value can have.
    /// </summary>
    /// <value>The integer min value. The default value is 100.</value>
    public int MaxValue
    {
        get => maxValue;
        set
        {
            maxValue =
                value < minValue ?
                minValue :
                value;
            
            if (crrValue > maxValue)
                Current = maxValue;
            
            maxChanged();
        }
    }

    /// <summary>
    /// The current value of status.
    /// </summary>
    /// <value>The integer current value. The default value is the max value. </value>
    public int Current
    {
        get => crrValue;
        set
        {
            if (value < minValue)
            {
                Minimize();
                return;
            }

            if (value > maxValue)
            {
                Maximize();
                return;
            }

            setValue(value);
        }
    }

    public Status(int min, int stt, int max)
    {
        this.minValue = min;
        this.crrValue = stt;
        this.maxValue = max;
    }

    public Status(int stt, int max) : this(0, stt, max) { }

    public Status(int max) : this(0, max, max) { }

    public Status() : this(0, 100, 100) { }

    /// <summary>
    /// Set the current value to max value.
    /// </summary>
    public void Maximize()
    {
        setValue(maxValue);
        maxReached();
    }

    /// <summary>
    /// Set the current value to min value.
    /// </summary>
    public void Minimize()
    {
        setValue(minValue);
        minReached();
    }

    private void setValue(int value)
    {
        this.crrValue = value;
        valueChanged();
    }

    private void maxReached()
    {
        if (this.OnMaxChanged == null)
            return;
        this.OnMaxChanged(this);
    }

    private void minReached()
    {
        if (this.OnMinReached == null)
            return;
        this.OnMinReached(this);
    }

    private void valueChanged()
    {
        if (this.OnValueChanged == null)
            return;
        this.OnValueChanged(this);
    }

    private void maxChanged()
    {
        if (this.OnMaxChanged == null)
            return;
        this.OnMaxChanged(this);
    }

    private void minChanged()
    {
        if (this.OnMinChanged == null)
            return;
        this.OnMinChanged(this);
    }

    /// <summary>
    /// Occurs when the current value reach the max value.
    /// </summary>
    public event Action<Status> OnMaxReached;

    /// <summary>
    /// Occurs when the current value reach the min value.
    /// </summary>
    public event Action<Status> OnMinReached;

    /// <summary>
    /// Occurs when the current value changes.
    /// </summary>
    public event Action<Status> OnValueChanged;

    /// <summary>
    /// Occurs when the max value changes.
    /// </summary>
    public event Action<Status> OnMaxChanged;

    /// <summary>
    /// Occurs when the min value changes.
    /// </summary>
    public event Action<Status> OnMinChanged;

    public static Status operator +(Status status, int value)
    {
        status.Current += value;
        return status;
    }

    public static Status operator -(Status status, int value)
    {
        status.Current -= value;
        return status;
    }

    public static Status operator *(Status status, float value)
    {
        float newValue = value * status.Current;
        status.Current = (int)newValue;
        return status;
    }

    public static implicit operator Status((int min, int stt, int max) tuple)
        => new Status(tuple.min, tuple.stt, tuple.max);
    
    public static implicit operator Status((int stt, int max) tuple)
        => new Status(tuple.stt, tuple.max);
    
    public static implicit operator Status(int max)
        => new Status(max);
}