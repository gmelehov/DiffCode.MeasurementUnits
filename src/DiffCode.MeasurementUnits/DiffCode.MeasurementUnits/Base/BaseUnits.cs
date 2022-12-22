using DiffCode.MeasurementUnits.Interfaces;



namespace DiffCode.MeasurementUnits.Base;


/// <summary>
/// <para>Базовая модель единицы измерения.</para>
/// </summary>
/// <typeparam name="TUnits">Тип единицы измерения.</typeparam>
/// <typeparam name="TEnum">Тип перечисления единицы измерения.</typeparam>
public abstract record BaseUnits<TUnits, TEnum> : IUnits<TUnits, TEnum> where TEnum : struct, Enum
{
  protected BaseUnits(TEnum units) => Units = units;





  /// <summary>
  /// <para>Перечисление единицы измерения.</para>
  /// </summary>
  public TEnum Units { get; }

}


