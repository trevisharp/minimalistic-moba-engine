using System;

namespace MiniMoba;

public class Status
{
    private int minValue = 0;
    private int maxValue = 0;
    private int crrValue = 0;

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

    private Status(int min, int stt, int max)
    {
        this.minValue = min;
        this.crrValue = stt;
        this.maxValue = max;
    }

    public void Maximize()
    {
        setValue(maxValue);
        maxReached();
    }

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

    public event Action<Status> OnMaxReached;
    public event Action<Status> OnMinReached;
    public event Action<Status> OnValueChanged;
    public event Action<Status> OnMaxChanged;
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
        => new Status(0, tuple.stt, tuple.max);
    
    public static implicit operator Status(int max)
        => new Status(0, max, max);
}