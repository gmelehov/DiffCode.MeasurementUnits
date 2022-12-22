using DiffCode.MeasurementUnits.Interfaces;



namespace DiffCode.MeasurementUnits.Models;


/// <summary>
/// <para>Время.</para>
/// </summary>
public readonly record struct TimeUnits : IUnits<TimeUnits, TimeMeasure.Unit>
{
  public TimeUnits(TimeMeasure.Unit unit) => Units = unit;



  /// <summary>
  /// <inheritdoc />
  /// </summary>
  public readonly TimeMeasure.Unit Units { get; }




  public static readonly TimeUnits Minute = new(TimeMeasure.Unit.Minute);

  public static readonly TimeUnits Hour = new(TimeMeasure.Unit.Hour);

  public static readonly TimeUnits Day = new(TimeMeasure.Unit.Day);

  public static readonly TimeUnits WorkDay = new(TimeMeasure.Unit.WorkDay);

  public static readonly TimeUnits CalendDay = new(TimeMeasure.Unit.CalendDay);

  public static readonly TimeUnits Week = new(TimeMeasure.Unit.Week);

  public static readonly TimeUnits Month = new(TimeMeasure.Unit.Month);

  public static readonly TimeUnits Quarter = new(TimeMeasure.Unit.Quarter);

  public static readonly TimeUnits Year = new(TimeMeasure.Unit.Year);

}
