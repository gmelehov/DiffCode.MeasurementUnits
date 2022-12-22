using DiffCode.MeasurementUnits.Interfaces;



namespace DiffCode.MeasurementUnits.Models;

/// <summary>
/// <para>Сущность.</para>
/// </summary>
public readonly record struct EssenceUnits : IUnits<EssenceUnits, EssenceMeasure.Unit>
{
  public EssenceUnits(EssenceMeasure.Unit unit) => Units = unit;




  /// <summary>
  /// <inheritdoc />
  /// </summary>
  public EssenceMeasure.Unit Units { get; }





  public static readonly EssenceUnits Instance = new(EssenceMeasure.Unit.Instance);

  public static readonly EssenceUnits Piece = new(EssenceMeasure.Unit.Piece);

}