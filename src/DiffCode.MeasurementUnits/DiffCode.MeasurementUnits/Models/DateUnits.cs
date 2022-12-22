using DiffCode.MeasurementUnits.Interfaces;



namespace DiffCode.MeasurementUnits.Models;

/// <summary>
/// <para>Даты/дни.</para>
/// </summary>
public readonly record struct DateUnits : IUnits<DateUnits, DateMeasure.Unit>
{
  public DateUnits(DateMeasure.Unit unit) => Units = unit;




  /// <summary>
  /// <inheritdoc />
  /// </summary>
  public readonly DateMeasure.Unit Units { get; }




  public static readonly DateUnits DayOfWeek = new(DateMeasure.Unit.DayOfWeek);

  public static readonly DateUnits DayOfMonth = new(DateMeasure.Unit.DayOfMonth);

}
