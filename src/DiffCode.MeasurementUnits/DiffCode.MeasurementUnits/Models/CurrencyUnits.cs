using DiffCode.MeasurementUnits.Interfaces;



namespace DiffCode.MeasurementUnits.Models;

/// <summary>
/// <para>Валюта.</para>
/// </summary>
public readonly record struct CurrencyUnits : IUnits<CurrencyUnits, CurrencyMeasure.Unit>
{
  public CurrencyUnits(CurrencyMeasure.Unit unit) => Units = unit;




  /// <summary>
  /// <inheritdoc />
  /// </summary>
  public readonly CurrencyMeasure.Unit Units { get; }




  public static readonly CurrencyUnits Rouble = new(CurrencyMeasure.Unit.Rouble);

  public static readonly CurrencyUnits Dollar = new(CurrencyMeasure.Unit.Dollar);

  public static readonly CurrencyUnits Euro = new(CurrencyMeasure.Unit.Euro);

}